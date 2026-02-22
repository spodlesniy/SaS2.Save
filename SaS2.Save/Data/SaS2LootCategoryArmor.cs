using static SaS2.Save.SaS2LootField;

namespace SaS2.Save
{
    public class SaS2LootCategoryArmor : SaS2LootCategory
    {
        public enum SaS2LootCategoryArmorSubTypes
        {
            SUBTYPE_HELM = 0,
            SUBTYPE_ARMOR = 1,
            SUBTYPE_GLOVES = 2,
            SUBTYPE_BOOTS = 3,

            TotalCount
        }

        public enum SaS2LootCategoryArmorFields
        {
            FIELD_PHYS_DEF = 0,
            FIELD_FIRE_DEF = 1,
            FIELD_COLD_DEF = 2,
            FIELD_POISON_DEF = 3,
            FIELD_LIGHT_DEF = 4,
            FIELD_DARK_DEF = 5,
            FIELD_WEIGHT = 6,
            FIELD_CRAFTING_LOOT_1 = 7,
            FIELD_CRAFTING_LOOT_1_COUNT = 8,
            FIELD_CRAFTING_LOOT_2 = 9,
            FIELD_CRAFTING_LOOT_2_COUNT = 10,
            FIELD_CRAFTING_LOOT_3 = 11,
            FIELD_CRAFTING_LOOT_3_COUNT = 12,
            FIELD_POISE = 13,
            FIELD_UPGRADE_SCALE = 14,
            FIELD_BASE_UPGRADE = 15,
            FIELD_CLASS_LEVEL = 16,
            FIELD_HEAVY = 17,

            TotalCount,
        }

        public enum SaS2LootCategoryArmorFlags
        {
            FLAG_FULL_HELM = 0,
            FLAG_HAT_HELM = 1,
            FLAG_HEADBAND = 2,
            FLAG_HOOD = 3,
            FLAG_EAR_HAT = 4,
            FLAG_HEAVY_ARMOR = 5,
            FLAG_ELEM_FIRE = 6,
            FLAG_ELEM_WATER = 7,
            FLAG_ELEM_LIT = 8,
            FLAG_ELEM_POISON = 9,
            FLAG_ELEM_EARTH = 10,
            FLAG_ELEM_TIME = 11,
            FLAG_ELEM_FLESH = 12,
            FLAG_ELEM_FUNGUS = 13,
            FLAG_ELEM_MECH = 14,
            FLAG_ELEM_DEMON = 15,
            FLAG_ELEM_DRAGON = 16,
            FLAG_ELEM_BOOKS = 17,
            FLAG_ELEM_AIR = 18,
            FLAG_ELEM_ICE = 19,
            FLAG_ELEM_FORCE = 20,
            FLAG_ELEM_DIVINE = 21,
            FLAG_ELEM_LIGHT = 22,
            FLAG_ELEM_BLOOD = 23,
            FLAG_ELEM_UNDEAD = 24,
            FLAG_ELEM_MIND = 25,
            FLAG_ELEM_DARK = 26,
            FLAG_BAREFOOT_SKIRT = 27,
            FLAG_PUNCH_POWER = 28,

            TotalCount
        }

        public override List<SaS2LootField> CreateFields()
        {
            return
            [
                new((int)SaS2LootCategoryArmorFields.FIELD_CLASS_LEVEL, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryArmorFields.FIELD_PHYS_DEF, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryArmorFields.FIELD_FIRE_DEF, 0),
                new((int)SaS2LootCategoryArmorFields.FIELD_COLD_DEF, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryArmorFields.FIELD_POISON_DEF, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryArmorFields.FIELD_LIGHT_DEF, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryArmorFields.FIELD_DARK_DEF, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryArmorFields.FIELD_POISE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryArmorFields.FIELD_WEIGHT, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryArmorFields.FIELD_HEAVY, (int)SaS2LootFieldDataType.DATA_TYPE_BOOLEAN),
                new((int)SaS2LootCategoryArmorFields.FIELD_UPGRADE_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryArmorFields.FIELD_BASE_UPGRADE, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_1, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_1_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_2, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_3_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_3, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_3_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT)
            ];
        }

        public override string GetFieldName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryArmorFields.FIELD_HEAVY => "Heavy",
                (int)SaS2LootCategoryArmorFields.FIELD_CLASS_LEVEL => "Class Level",
                (int)SaS2LootCategoryArmorFields.FIELD_BASE_UPGRADE => "Base Upgrade",
                (int)SaS2LootCategoryArmorFields.FIELD_UPGRADE_SCALE => "Upgrade Scale",
                (int)SaS2LootCategoryArmorFields.FIELD_POISE => "Poise",
                (int)SaS2LootCategoryArmorFields.FIELD_PHYS_DEF => "Phys Def",
                (int)SaS2LootCategoryArmorFields.FIELD_FIRE_DEF => "Fire Def",
                (int)SaS2LootCategoryArmorFields.FIELD_COLD_DEF => "Cold Def",
                (int)SaS2LootCategoryArmorFields.FIELD_POISON_DEF => "Poison Def",
                (int)SaS2LootCategoryArmorFields.FIELD_LIGHT_DEF => "Light Def",
                (int)SaS2LootCategoryArmorFields.FIELD_DARK_DEF => "Dark Def",
                (int)SaS2LootCategoryArmorFields.FIELD_WEIGHT => "Weight",
                (int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_1 => "Crafting Loot 1",
                (int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_1_COUNT => "- Loot 1 Count",
                (int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_2 => "Crafting Loot 2",
                (int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_2_COUNT => "- Loot 2 Count",
                (int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_3 => "Crafting Loot 3",
                (int)SaS2LootCategoryArmorFields.FIELD_CRAFTING_LOOT_3_COUNT => "- Loot 3 Count",

                _ => base.GetFieldName(idx),
            };
        }

        public override string GetSubtypeName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryArmorSubTypes.SUBTYPE_ARMOR => "Armor",
                (int)SaS2LootCategoryArmorSubTypes.SUBTYPE_HELM => "Helm",
                (int)SaS2LootCategoryArmorSubTypes.SUBTYPE_BOOTS => "Boots",
                (int)SaS2LootCategoryArmorSubTypes.SUBTYPE_GLOVES => "Gloves",

                _ => base.GetSubtypeName(idx),
            };
        }

        public override string GetFlagName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryArmorFlags.FLAG_PUNCH_POWER => "Punch Power",
                (int)SaS2LootCategoryArmorFlags.FLAG_BAREFOOT_SKIRT => "Barefoot Skirt",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_FIRE => "Elem|Fire",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_WATER => "Elem|Water",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_LIT => "Elem|Lit",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_POISON => "Elem|Poison",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_EARTH => "Elem|Earth",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_TIME => "Elem|Time",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_FLESH => "Elem|Flesh",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_FUNGUS => "Elem|Fungus",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_MECH => "Elem|Mech",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_DEMON => "Elem|Demon",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_DRAGON => "Elem|Dragon",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_BOOKS => "Elem|Books",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_AIR => "Elem|Air",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_ICE => "Elem|Ice",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_FORCE => "Elem|Force",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_DIVINE => "Elem|Divine",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_LIGHT => "Elem|Light",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_BLOOD => "Elem|Blood",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_UNDEAD => "Elem|Undead",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_MIND => "Elem|Mind",
                (int)SaS2LootCategoryArmorFlags.FLAG_ELEM_DARK => "Elem|Dark",
                (int)SaS2LootCategoryArmorFlags.FLAG_HEAVY_ARMOR => "Heavy Armor",
                (int)SaS2LootCategoryArmorFlags.FLAG_FULL_HELM => "Full Helm",
                (int)SaS2LootCategoryArmorFlags.FLAG_HAT_HELM => "Hat Helm",
                (int)SaS2LootCategoryArmorFlags.FLAG_HEADBAND => "Headband",
                (int)SaS2LootCategoryArmorFlags.FLAG_HOOD => "Hood",
                (int)SaS2LootCategoryArmorFlags.FLAG_EAR_HAT => "Ear Hat",

                _ => base.GetFlagName(idx),
            };
        }

        public override int GetSubtypeCount()
        {
            return (int)SaS2LootCategoryArmorSubTypes.TotalCount;
        }

        public override int GetFlagCount()
        {
            return (int)SaS2LootCategoryArmorFlags.TotalCount;
        }

        public override int GetFieldsCount()
        {
            return (int)SaS2LootCategoryArmorFields.TotalCount;
        }
    }
}
