using static SaS2.Save.SaS2LootCategory;
using static SaS2.Save.SaS2LootCategoryArmor;
using static SaS2.Save.SaS2LootCategoryCharm;
using static SaS2.Save.SaS2LootCategoryConsumable;
using static SaS2.Save.SaS2LootCategoryRanged;
using static SaS2.Save.SaS2LootCategoryWeapon;

namespace SaS2.Save
{
    public static class SaS2LootCatalog
    {
        public enum ArtifactType
        {
            ARTIFACTS_ATTACK = 0,
            ARTIFACTS_DEFENSE = 1,
            ARTIFACTS_UTILITY = 2,

            TotalCount
        }

        public static List<SaS2LootDef> lootDefs = [];
        public static SaS2LootCategory[] category = [];

        public static int unarmedIdx = -1;
        public static int[][] artifactIdx = [];
        public static int totalReplenishTypes;
        public static int smallClothesBootsIdx = -1;
        public static int smallClothesArmorIdx = -1;
        public static int cloudFeatherIdx = -1;
        //public static int consumablesTexIdx = -1;

        public static void Init()
        {
            lootDefs = [];

            category = new SaS2LootCategory[(int)SaS2LootCategoryType.TotalCount];

            category[(int)SaS2LootCategoryType.TYPE_ARMOR] = new SaS2LootCategoryArmor();
            category[(int)SaS2LootCategoryType.TYPE_WEAPON] = new SaS2LootCategoryWeapon();
            category[(int)SaS2LootCategoryType.TYPE_RANGED] = new SaS2LootCategoryRanged();
            category[(int)SaS2LootCategoryType.TYPE_CONSUMABLE] = new SaS2LootCategoryConsumable();
            category[(int)SaS2LootCategoryType.TYPE_MATERIAL] = new SaS2LootCategoryMaterial();
            category[(int)SaS2LootCategoryType.TYPE_KEY] = new SaS2LootCategoryKey();
            category[(int)SaS2LootCategoryType.TYPE_CHARM] = new SaS2LootCategoryCharm();
            category[(int)SaS2LootCategoryType.TYPE_MAGIC] = new SaS2LootCategoryMagic();
            category[(int)SaS2LootCategoryType.TYPE_GESTURE] = new SaS2LootCategoryGesture();
        }

        public static int GetLootIdxOrNegative(string name)
        {
            if (name == null || name == "" || lootDefs == null)
            {
                return -1;
            }

            int result = -1;

            for (int i = 0; i < lootDefs.Count; i++)
            {
                if (lootDefs[i].name == name)
                {
                    result = i;

                    // ToDo: can have several items with the same name?
                }
            }

            return result;
        }

        public static void Read(BinaryReader reader)
        {
            int num = reader.ReadInt32();

            lootDefs.Clear();

            for (int i = 0; i < num; i++)
            {
                var lootDef = new SaS2LootDef();
                lootDef.Read(reader);

                lootDefs.Add(lootDef);
            }

            for (int j = 0; j < lootDefs.Count; j++)
            {
                if (lootDefs[j].type == (int)SaS2LootCategoryType.TYPE_WEAPON)
                {
                    var lootDefWeapon = lootDefs[j];

                    lootDefWeapon.magicIdx = new int[3];

                    for (int k = 0; k < 3; k++)
                    {
                        lootDefWeapon.magicIdx[k] = -1;
                    }

                    lootDefWeapon.magicIdx[0] = GetLootIdxOrNegative(lootDefWeapon.lootFields[14].strData);
                    lootDefWeapon.magicIdx[1] = GetLootIdxOrNegative(lootDefWeapon.lootFields[15].strData);
                    lootDefWeapon.magicIdx[2] = GetLootIdxOrNegative(lootDefWeapon.lootFields[16].strData);
                }

                if (lootDefs[j].type == (int)SaS2LootCategoryType.TYPE_CONSUMABLE)
                {
                    var lootDefConsumable = lootDefs[j];
                    lootDefConsumable.replenishIdx = -1;

                    if (lootDefConsumable.lootFields[(int)SaS2LootCategoryConsumableFields.FIELD_REPLENISHABLE].bData)
                    {
                        lootDefConsumable.replenishIdx =
                            GetLootIdxOrNegative(lootDefConsumable.lootFields[(int)SaS2LootCategoryConsumableFields.FIELD_BASE_REPLENISH_COUNT].strData);
                    }
                }
            }
        }

        public static void Read(string path)
        {
            using (var reader = new BinaryReader(File.OpenRead(path)))
            {
                Read(reader);
            }

            totalReplenishTypes = 0;
            smallClothesArmorIdx = GetLootIdxOrNegative("smallclothes_armor");
            smallClothesBootsIdx = GetLootIdxOrNegative("smallclothes_boots");
            cloudFeatherIdx = GetLootIdxOrNegative("revive_feather");
            unarmedIdx = GetLootIdxOrNegative("unarmed");

            var list = new List<int>();
            var list2 = new List<int>();
            var list3 = new List<int>();

            for (int i = 0; i < lootDefs.Count; i++)
            {
                if (lootDefs[i].type == (int)SaS2LootCategoryType.TYPE_CHARM)
                {
                    switch (lootDefs[i].subType)
                    {
                        case (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_ARTIFACT_ATTACK:
                            list.Add(i);
                            break;
                        case (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_ARTIFACT_DEFENSE:
                            list2.Add(i);
                            break;
                        case (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_ARTIFACT_UTILITY:
                            list3.Add(i);
                            break;
                    }
                }
                else if (
                    lootDefs[i].type == (int)SaS2LootCategoryType.TYPE_CONSUMABLE &&
                    lootDefs[i].lootFields[(int)SaS2LootCategoryConsumableFields.FIELD_REPLENISHABLE].bData)
                {
                    totalReplenishTypes++;
                }
            }

            artifactIdx = new int[(int)ArtifactType.TotalCount][];
            artifactIdx[(int)ArtifactType.ARTIFACTS_ATTACK] = [.. list];
            artifactIdx[(int)ArtifactType.ARTIFACTS_DEFENSE] = [.. list2];
            artifactIdx[(int)ArtifactType.ARTIFACTS_UTILITY] = [.. list3];
        }

        public static int GetBaseUpgrade(int idx)
        {
            var lootDef = lootDefs[idx];

            return lootDef.type switch
            {
                (int)SaS2LootCategoryType.TYPE_ARMOR => lootDef.lootFields[(int)SaS2LootCategoryArmorFields.FIELD_BASE_UPGRADE].iData,
                (int)SaS2LootCategoryType.TYPE_WEAPON => lootDef.lootFields[(int)SaS2LootCategoryWeaponFields.FIELD_BASE_UPGRADE].iData,
                (int)SaS2LootCategoryType.TYPE_RANGED => lootDef.lootFields[(int)SaS2LootCategoryRangedFields.FIELD_BASE_UPGRADE].iData,

                _ => 0,
            };
        }
    }
}
