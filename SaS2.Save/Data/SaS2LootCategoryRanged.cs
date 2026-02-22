using static SaS2.Save.SaS2LootField;

namespace SaS2.Save
{
    public class SaS2LootCategoryRanged : SaS2LootCategory
    {
        public enum SaS2LootCategoryRangedFields
        {
            FIELD_PHYS_ATTACK = 0,
            FIELD_ELEM_ATTACK = 1,
            FIELD_CRAFTING_LOOT_1 = 2,
            FIELD_CRAFTING_LOOT_1_COUNT = 3,
            FIELD_CRAFTING_LOOT_2 = 4,
            FIELD_CRAFTING_LOOT_2_COUNT = 5,
            FIELD_CRAFTING_LOOT_3 = 6,
            FIELD_CRAFTING_LOOT_3_COUNT = 7,
            FIELD_STR_SCALE = 8,
            FIELD_DEX_SCALE = 9,
            FIELD_ARCANA_SCALE = 10,
            FIELD_LUCK_SCALE = 11,
            FIELD_UPGRADE_SCALE = 12,
            FIELD_BASE_UPGRADE = 13,
            FIELD_REQ_STR = 14,
            FIELD_REQ_DEX = 15,
            FIELD_REQ_ARCANA = 16,
            FIELD_REQ_LUCK = 17,
            FIELD_REQ_CONVICTION = 18,
            FIELD_CONVICTION_SCALE = 19,
            FIELD_CLASS_LEVEL = 20,

            TotalCount
        }

        public enum SaS2LootCategoryRangedFlags
        {
            FLAG_ELEM_FIRE = 0,
            FLAG_ELEM_WATER = 1,
            FLAG_ELEM_LIT = 2,
            FLAG_ELEM_POISON = 3,
            FLAG_ELEM_EARTH = 4,
            FLAG_ELEM_TIME = 5,
            FLAG_ELEM_FLESH = 6,
            FLAG_ELEM_FUNGUS = 7,
            FLAG_ELEM_MECH = 8,
            FLAG_ELEM_DEMON = 9,
            FLAG_ELEM_DRAGON = 10,
            FLAG_ELEM_BOOKS = 11,
            FLAG_ELEM_AIR = 12,
            FLAG_ELEM_ICE = 13,
            FLAG_ELEM_FORCE = 14,
            FLAG_ELEM_DIVINE = 15,
            FLAG_ELEM_LIGHT = 16,
            FLAG_ELEM_BLOOD = 17,
            FLAG_ELEM_UNDEAD = 18,
            FLAG_ELEM_MIND = 19,
            FLAG_ELEM_DARK = 20,
            FLAG_FULL_PROC = 21,

            TotalCount
        }

        public enum SaS2LootCategoryRangedSubTypes
        {
            SUBTYPE_THROWING_DAGGERS = 0,
            SUBTYPE_CROSSBOW = 1,
            SUBTYPE_FLINTLOCK = 2,
            SUBTYPE_LONGBOW = 3,
            SUBTYPE_ARBALEST = 4,
            SUBTYPE_RIFLE = 5,
            SUBTYPE_THROWING_AXE = 6,
            SUBTYPE_CHANNELING_ROD = 7,
            SUBTYPE_THROWABLE = 8,

            TotalCount
        }

        public override List<SaS2LootField> CreateFields()
        {
            return [
                new((int)SaS2LootCategoryRangedFields.FIELD_CLASS_LEVEL, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryRangedFields.FIELD_PHYS_ATTACK, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryRangedFields.FIELD_ELEM_ATTACK, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryRangedFields.FIELD_REQ_STR, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryRangedFields.FIELD_REQ_DEX, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryRangedFields.FIELD_REQ_ARCANA, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryRangedFields.FIELD_REQ_CONVICTION, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryRangedFields.FIELD_REQ_LUCK, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryRangedFields.FIELD_STR_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryRangedFields.FIELD_DEX_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryRangedFields.FIELD_ARCANA_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryRangedFields.FIELD_CONVICTION_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryRangedFields.FIELD_LUCK_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryRangedFields.FIELD_UPGRADE_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryRangedFields.FIELD_BASE_UPGRADE, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_1, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_1_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_2, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_2_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_3, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_3_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT)
            ];
        }

        public override string GetFieldName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryRangedFields.FIELD_CLASS_LEVEL => "Class Level",
                (int)SaS2LootCategoryRangedFields.FIELD_REQ_STR => "Req Str",
                (int)SaS2LootCategoryRangedFields.FIELD_REQ_DEX => "Req Dex",
                (int)SaS2LootCategoryRangedFields.FIELD_REQ_ARCANA => "Req Arcana",
                (int)SaS2LootCategoryRangedFields.FIELD_REQ_LUCK => "Req Luck",
                (int)SaS2LootCategoryRangedFields.FIELD_REQ_CONVICTION => "Req Conv",
                (int)SaS2LootCategoryRangedFields.FIELD_BASE_UPGRADE => "Base Upgrade",
                (int)SaS2LootCategoryRangedFields.FIELD_UPGRADE_SCALE => "Upgrade Scale",
                (int)SaS2LootCategoryRangedFields.FIELD_STR_SCALE => "Str Scale",
                (int)SaS2LootCategoryRangedFields.FIELD_DEX_SCALE => "Dex Scale",
                (int)SaS2LootCategoryRangedFields.FIELD_ARCANA_SCALE => "Arcana Scale",
                (int)SaS2LootCategoryRangedFields.FIELD_CONVICTION_SCALE => "Conv Scale",
                (int)SaS2LootCategoryRangedFields.FIELD_LUCK_SCALE => "Luck Scale",
                (int)SaS2LootCategoryRangedFields.FIELD_PHYS_ATTACK => "Phys Atk",
                (int)SaS2LootCategoryRangedFields.FIELD_ELEM_ATTACK => "Elem Percent",
                (int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_1 => "Crafting Loot 1",
                (int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_1_COUNT => "- Loot 1 Count",
                (int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_2 => "Crafting Loot 2",
                (int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_2_COUNT => "- Loot 2 Count",
                (int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_3 => "Crafting Loot 3",
                (int)SaS2LootCategoryRangedFields.FIELD_CRAFTING_LOOT_3_COUNT => "- Loot 3 Count",

                _ => base.GetFieldName(idx),
            };
        }

        public override string GetFlagName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryRangedFlags.FLAG_FULL_PROC => "Full Proc",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_FIRE => "Elem|Fire",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_WATER => "Elem|Water",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_LIT => "Elem|Lit",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_POISON => "Elem|Poison",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_EARTH => "Elem|Earth",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_TIME => "Elem|Time",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_FLESH => "Elem|Flesh",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_FUNGUS => "Elem|Fungus",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_MECH => "Elem|Mech",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_DEMON => "Elem|Demon",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_DRAGON => "Elem|Dragon",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_BOOKS => "Elem|Books",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_AIR => "Elem|Air",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_ICE => "Elem|Ice",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_FORCE => "Elem|Force",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_DIVINE => "Elem|Divine",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_LIGHT => "Elem|Light",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_BLOOD => "Elem|Blood",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_UNDEAD => "Elem|Undead",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_MIND => "Elem|Mind",
                (int)SaS2LootCategoryRangedFlags.FLAG_ELEM_DARK => "Elem|Dark",

                _ => base.GetFlagName(idx),
            };
        }

        public override string GetSubtypeName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryRangedSubTypes.SUBTYPE_THROWABLE => "Throwable",
                (int)SaS2LootCategoryRangedSubTypes.SUBTYPE_THROWING_DAGGERS => "Throwing Daggers",
                (int)SaS2LootCategoryRangedSubTypes.SUBTYPE_RIFLE => "Rifle",
                (int)SaS2LootCategoryRangedSubTypes.SUBTYPE_LONGBOW => "Longbow",
                (int)SaS2LootCategoryRangedSubTypes.SUBTYPE_FLINTLOCK => "Flintlock",
                (int)SaS2LootCategoryRangedSubTypes.SUBTYPE_CROSSBOW => "Crossbow",
                (int)SaS2LootCategoryRangedSubTypes.SUBTYPE_ARBALEST => "Arbalest",
                (int)SaS2LootCategoryRangedSubTypes.SUBTYPE_THROWING_AXE => "Throwing Axe",
                (int)SaS2LootCategoryRangedSubTypes.SUBTYPE_CHANNELING_ROD => "Channeling Rod",

                _ => base.GetSubtypeName(idx),
            };
        }

        public override int GetSubtypeCount()
        {
            return (int)SaS2LootCategoryRangedSubTypes.TotalCount;
        }

        public override int GetFlagCount()
        {
            return (int)SaS2LootCategoryRangedFlags.TotalCount;
        }

        public override int GetFieldsCount()
        {
            return (int)SaS2LootCategoryRangedFields.TotalCount;
        }
    }
}
