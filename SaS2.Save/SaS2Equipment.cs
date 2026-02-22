using static SaS2.Save.SaS2LootCategoryConsumable;

namespace SaS2.Save
{
    public class SaS2Equipment
    {
        public int maxScaledConsumableUpgrade = 10;

        public enum EquipmentSlot
        {
            EQUIPMENT_HELM = 0,
            EQUIPMENT_ARMOR = 1,
            EQUIPMENT_BOOTS = 2,
            EQUIPMENT_GLOVES = 3,
            EQUIPMENT_WEAPON_1 = 4,
            EQUIPMENT_WEAPON_2 = 5,
            EQUIPMENT_RANGED = 6,
            EQUIPMENT_RING_1 = 7,
            EQUIPMENT_RING_2 = 8,
            EQUIPMENT_AMULET = 9,
            EQUIPMENT_TOOL_1 = 10,
            EQUIPMENT_TOOL_2 = 11,
            EQUIPMENT_TOOL_3 = 12,
            EQUIPMENT_TOOL_4 = 13,
            EQUIPMENT_TOOL_5 = 14,
            EQUIPMENT_TOOL_6 = 15,
            EQUIPMENT_TOOL_7 = 16,
            EQUIPMENT_TOOL_8 = 17,
            EQUIPMENT_TOOL_9 = 18,
            EQUIPMENT_TOOL_10 = 19,
            EQUIPMENT_DAGGER = 20,
            EQUIPMENT_AMMUNITION = 21,
            EQUIPMENT_ARTIFACT_1 = 22,
            EQUIPMENT_ARTIFACT_2 = 23,
            EQUIPMENT_ARTIFACT_3 = 24,
            EQUIPMENT_GESTURE_1 = 25,
            EQUIPMENT_GESTURE_2 = 26,
            EQUIPMENT_GESTURE_3 = 27,
            EQUIPMENT_GESTURE_4 = 28,
            EQUIPMENT_GESTURE_5 = 29,
            EQUIPMENT_GESTURE_6 = 30,

            TOTAL_EQUIPMENT_SLOTS,
        }

        public enum AbilityItems
        {
            GRAPPLE = 0,
            ZIPLINE_STONE = 1,
            CIRCLE_STONE = 2,
            PARACHUTE = 3,
            UNUSED = 4,
            TRUE_DEVOUR = 5,

            TotalCount
        }

        private readonly static Dictionary<string, AbilityItems> itemToAbilityIndexMapper = new()
        {
            { "grappling_hook", AbilityItems.GRAPPLE },
            { "power_stones", AbilityItems.ZIPLINE_STONE },
            { "moon_stone", AbilityItems.CIRCLE_STONE },
            { "parachute", AbilityItems.PARACHUTE },
        };

        public int[] equippedItems = [];
        private bool[] abilityItems = [];
        public int abilityItemBits = 0;
        public List<SaS2Item> inventoryItems = [];

        public SaS2Equipment()
        {
            Reset();

            abilityItems = new bool[(int)AbilityItems.TotalCount];
        }

        public void Reset()
        {
            inventoryItems = [];

            equippedItems = new int[(int)EquipmentSlot.TOTAL_EQUIPMENT_SLOTS];
            for (int i = 0; i < equippedItems.Length; i++)
            {
                equippedItems[i] = -1;
            }
        }

        public void Read(BinaryReader reader)
        {
            int invItemCount = reader.ReadInt32();

            inventoryItems.Clear();
            for (int i = 0; i < invItemCount; i++)
            {
                inventoryItems.Add(new SaS2Item(reader));
            }

            equippedItems = new int[(int)EquipmentSlot.TOTAL_EQUIPMENT_SLOTS];
            for (int j = 0; j < equippedItems.Length; j++)
            {
                equippedItems[j] = reader.ReadInt32();
            }

            // It's not needed for save editing
            UpdateAbilityItems();
        }

        protected int GetItemIdx(string item)
        {
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if ((inventoryItems[i].count > 0) && SaS2LootCatalog.lootDefs[inventoryItems[i].lootIdx].name == item)
                {
                    return i;
                }
            }

            return -1;
        }

        protected void UpdateAbilityItems()
        {
            for (int i = 0; i < abilityItems.Length; i++)
            {
                abilityItems[i] = false;
            }

            foreach (var item in itemToAbilityIndexMapper.Keys)
            {
                if (GetItemIdx(item) > -1)
                {
                    abilityItems[(int)itemToAbilityIndexMapper[item]] = true;
                }
            }

            int itemIdx = GetItemIdx("truedevour");
            if (itemIdx > -1 && inventoryItems[itemIdx].count > 0)
            {
                abilityItems[5] = true;
            }

            int num = 0;
            for (int j = 0; j < abilityItems.Length; j++)
            {
                if (abilityItems[j])
                {
                    num |= 1 << j;
                }
            }
            if (num != abilityItemBits)
            {
                abilityItemBits = num;
            }
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(inventoryItems.Count);

            for (int i = 0; i < inventoryItems.Count; i++)
            {
                inventoryItems[i].Write(writer);
            }

            for (int j = 0; j < equippedItems.Length; j++)
            {
                writer.Write(equippedItems[j]);
            }
        }

        public int GetScaledConsumableUpgrade(int upgrade)
        {
            return Math.Min(upgrade, maxScaledConsumableUpgrade);
        }

        public int GetConsumableMax(SaS2Item item)
        {
            SaS2LootDef lootDef = SaS2LootCatalog.lootDefs[item.lootIdx];
            //if (ColosseumMgr.IsActive && ColosseumMgr.GetReplenishAmount(lootDef, out var amount))
            //{
            //    return amount;
            //}
            if (lootDef.lootFields[(int)SaS2LootCategoryConsumableFields.FIELD_REPLENISHABLE].bData)
            {
                int num = lootDef.lootFields[(int)SaS2LootCategoryConsumableFields.FIELD_BASE_REPLENISH_COUNT].iData +
                    GetScaledConsumableUpgrade(item.upgrade) * lootDef.lootFields[(int)SaS2LootCategoryConsumableFields.FIELD_EXPANSION_COUNT_PER_TIER].iData;

                //if (NetworkMgr.Instance.HasPartialHealingFlasks() && SaS2LootCatalog.lootDefs[item.lootIdx].name == "health_potion")
                //{
                //    num = num * 2 / 3;
                //}

                return num;
            }
            return lootDef.lootFields[(int)SaS2LootCategoryConsumableFields.FIELD_MAX].iData;
        }
    }
}
