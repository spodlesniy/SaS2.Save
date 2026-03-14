using static SaS2.Save.SaS2LootCategory;
using static SaS2.Save.SaS2LootCategoryConsumable;

namespace SaS2.Save
{
    public class SaS2LootDef
    {
        public static readonly int MAX_TRANSLATIONS = 20;

        public string name;
        public string[] title;
        public string[] description;

        public int type;
        public int subType;

        public float cost;

        // Image position in texture. x = img % 32 * 128; y = img / 32 * 128; size (width, height) = 128
        public int img;
        public int altImg;

        public string texture;
        public int texIdx;

        public int tex2Idx;
        public int[] magicIdx;

        public List<SaS2LootField> lootFields;

        public List<int> flags;

        public string tokenLoot;
        public int tokenLootIdx;
        public int tokenCost;

        public int replenishIdx;

        private void Init()
        {
            title = new string[20];
            description = new string[20];
            subType = 0;

            for (int i = 0; i < title.Length; i++)
            {
                title[i] = "New Loot";
            }

            for (int j = 0; j < description.Length; j++)
            {
                description[j] = "New Description";
            }

            texture = "";
            texIdx = -1;
            tex2Idx = -1;
            tokenLoot = "";
            tokenLootIdx = -1;
            tokenCost = 0;
            lootFields = [];
        }

        public SaS2LootDef()
        {
            name = "New Loot";

            Init();
        }

        public void Read(BinaryReader reader)
        {
            name = reader.ReadString();

            for (int i = 0; i < title.Length; i++)
            {
                title[i] = reader.ReadString();
            }

            for (int j = 0; j < description.Length; j++)
            {
                description[j] = reader.ReadString();
            }

            type = reader.ReadInt32();
            lootFields = SaS2LootCatalog.category[type].CreateFields();
            subType = reader.ReadInt32();
            cost = reader.ReadSingle();
            img = reader.ReadInt32();
            altImg = reader.ReadInt32();
            texture = reader.ReadString();

            int num = reader.ReadInt32();
            for (int k = 0; k < num; k++)
            {
                var lootField = new SaS2LootField(reader);
                for (int l = 0; l < lootFields.Count; l++)
                {
                    if (lootFields[l].ID == lootField.ID)
                    {
                        lootFields[l] = lootField;
                        break;
                    }
                }
            }

            flags = [];

            int flagCount = reader.ReadInt32();

            for (int m = 0; m < flagCount; m++)
            {
                flags.Add(reader.ReadInt32());
            }

            tokenLoot = reader.ReadString();
            tokenCost = reader.ReadInt32();

            lootFields.Sort((x, y) => x.ID.CompareTo(y.ID));
        }

        public Tuple<int, int> GetMinMaxCount()
        {
            bool stackable = type == (int)SaS2LootCategoryType.TYPE_CONSUMABLE || type == (int)SaS2LootCategoryType.TYPE_MATERIAL; // || countItemIdx > -1;

            if (type == (int)SaS2LootCategoryType.TYPE_CONSUMABLE)
            {
                if (lootFields[(int)SaS2LootCategoryConsumableFields.FIELD_MAX].iData == 1 || lootFields[(int)SaS2LootCategoryConsumableFields.FIELD_USES_AMMO].bData)
                {
                    stackable = false;
                }
                else if (
                    flags.Contains((int)SaS2LootCategoryConsumableFlags.FLAG_STAB_BLADE) ||
                    flags.Contains((int)SaS2LootCategoryConsumableFlags.FLAG_HOST_COOP) ||
                    flags.Contains((int)SaS2LootCategoryConsumableFlags.FLAG_OATH_CANDLE) ||
                    flags.Contains((int)SaS2LootCategoryConsumableFlags.FLAG_SHERIFF_CANDLE) ||
                    flags.Contains((int)SaS2LootCategoryConsumableFlags.FLAG_RESET_QP_TIMER) ||
                    flags.Contains((int)SaS2LootCategoryConsumableFlags.FLAG_HOST_INVASION) ||
                    flags.Contains((int)SaS2LootCategoryConsumableFlags.FLAG_CANCEL_QP_SEARCH))
                {
                    stackable = false;
                }
                else if (subType == (int)SaS2LootCategoryType.TYPE_RANGED)
                {
                    stackable = false;
                }
            }

            if (!stackable)
            {
                return new Tuple<int, int>(1, 1);
            }

            return new Tuple<int, int>(1, 1);
        }

        public int GetRarity(SaS2Item playerItem)
        {
            int result = 0;
            switch (type)
            {
                case 5:
                    result = 2;
                    if (flags.Contains(0))
                    {
                        result = 4;
                    }
                    break;
                case 3:
                    if (flags.Contains(11))
                    {
                        result = 1;
                    }
                    if (flags.Contains(12))
                    {
                        result = 2;
                    }
                    if (flags.Contains(13))
                    {
                        result = 3;
                    }
                    break;
                case 4:
                    if (flags.Contains(0))
                    {
                        result = 1;
                    }
                    if (flags.Contains(1))
                    {
                        result = 2;
                    }
                    if (flags.Contains(2))
                    {
                        result = 3;
                    }
                    if (flags.Contains(3))
                    {
                        result = 4;
                    }
                    break;
                case 6:
                    {
                        if (playerItem == null || playerItem.artifactData == null)
                        {
                            break;
                        }
                        int num = 0;
                        for (int i = 0; i < playerItem.artifactData.value.Length; i++)
                        {
                            if (playerItem.artifactData.value[i] > 0f)
                            {
                                num++;
                            }
                        }
                        switch (num)
                        {
                            case 2:
                                result = 1;
                                break;
                            case 3:
                                result = 2;
                                break;
                            case 4:
                                result = 3;
                                break;
                            case 5:
                                result = 4;
                                break;
                        }
                        break;
                    }
            }
            return result;
        }

        public bool HasFlag(int flagIdx)
        {
            for (int i = 0; i < flags.Count; i++)
            {
                if (flags[i] == flagIdx)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
