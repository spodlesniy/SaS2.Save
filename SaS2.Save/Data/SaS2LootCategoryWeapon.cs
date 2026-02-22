using static SaS2.Save.SaS2LootField;

namespace SaS2.Save
{
    public class SaS2LootCategoryWeapon : SaS2LootCategory
    {
        public enum SaS2LootCategoryWeaponFields
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
            FIELD_MAGIC_1 = 14,
            FIELD_MAGIC_2 = 15,
            FIELD_MAGIC_3 = 16,
            FIELD_REQ_STR = 17,
            FIELD_REQ_DEX = 18,
            FIELD_REQ_ARCANA = 19,
            FIELD_REQ_LUCK = 20,
            FIELD_REQ_CONVICTION = 21,
            FIELD_CONVICTION_SCALE = 22,
            FIELD_CLASS_LEVEL = 23,
            FIELD_MAGIC_1_CLASS = 24,
            FIELD_MAGIC_2_CLASS = 25,
            FIELD_MAGIC_3_CLASS = 26,
            FIELD_DARK_GLYPHS = 27,
            FIELD_MAGIC_1_COST = 28,
            FIELD_MAGIC_2_COST = 29,
            FIELD_MAGIC_3_COST = 30,
            FIELD_BLOCK_DAMAGE = 31,
            FIELD_BLOCK_STAMINA = 32,
            FIELD_MAGIC_1_COOLDOWN = 33,
            FIELD_MAGIC_2_COOLDOWN = 34,
            FIELD_MAGIC_3_COOLDOWN = 35,

            TotalCount
        }

        public enum SaS2LootCategoryWeaponFlags
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
            FLAG_RAGE = 21,
            FLAG_MP = 22,
            FLAG_BLUDGEON_PARTIAL = 23,
            FLAG_BLUDGEON_FULL = 24,
            FLAG_BLUDGEON_MEGA = 25,
            FLAG_SIDE_ATTACH = 26,
            FLAG_CHAIN_WHIP = 27,
            FLAG_ELEM_MUMMY = 28,
            FLAG_ELEM_GHOST = 29,
            FLAG_ELEM_RED_LIT = 30,
            FLAG_ELEM_RED_FIRE = 31,
            FLAG_ELEM_BLUE_DRAGON = 32,
            FLAG_ELEM_SKY = 33,
            FLAG_ELEM_MESSIAH = 34,
            FLAG_ELEM_OWL = 35,
            FLAG_ELEM_HAG = 36,
            FLAG_ELEM_DAWNLIGHT = 37,
            FLAG_ELEM_BLUEHEART = 38,
            FLAG_ELEM_SHERIFF = 39,
            FLAG_ELEM_OATH = 40,
            FLAG_ELEM_SHROUD = 41,
            FLAG_ELEM_CHAOS = 42,
            FLAG_FAST_HITTER = 43,
            FLAG_SLOW_HITTER = 44,
            FLAG_SLIDE = 45,
            FLAG_EXTRA_POISE_DMG = 46,
            FLAG_LESS_POISE_DMG = 47,
            FLAG_EXTRA_STAMINA_COST = 48,
            FLAG_LESS_STAMINA_COST = 49,
            FLAG_LONG_SLIDE = 50,
            FLAG_FASTER_HITTER = 51,
            FLAG_SLOWER_HITTER = 52,
            FLAG_WIDE_GLAIVE = 53,
            FLAG_ELEM_TRAITOR = 54,
            FLAG_ELEM_GOLD = 55,

            TotalCount
        }

        public enum SaS2LootCategoryWeaponMagics
        {
            MAGIC_X = 0,
            MAGIC_Y = 1,
            MAGIC_B = 2,

            TotalCount
        }

        public enum SaS2LootCategoryWeaponSubTypes
        {
            SUBTYPE_VANGUARD = 0,
            SUBTYPE_TWIN_DAGGERS = 1,
            SUBTYPE_AXE = 2,
            SUBTYPE_HALFSPEAR = 3,
            SUBTYPE_GREATHAMMER = 4,
            SUBTYPE_GLAIVE = 5,
            SUBTYPE_GREATBLADE = 6,
            SUBTYPE_STAVE = 7,
            SUBTYPE_ZWEIHANDER = 8,
            SUBTYPE_KATANA = 9,
            SUBTYPE_RAPIER = 10,
            SUBTYPE_WHIP = 11,
            SUBTYPE_BOUND = 12,
            SUBTYPE_SCYTHE = 13,
            SUBTYPE_CHAINSWORD = 14,
            SUBTYPE_GREATSCISSORS = 15,
            SUBTYPE_SWITCHBLADE = 16,
            SUBTYPE_GUNBLADE = 17,
            SUBTYPE_TRUEZWEI = 18,
            SUBTYPE_MACH_VANGUARD = 19,
            SUBTYPE_AXE_BLADE = 20,
            SUBTYPE_SPIN_DAGGERS = 21,
            SUBTYPE_CHAIN_BLADE = 22,

            TotalCount
        }

        public override List<SaS2LootField> CreateFields()
        {
            return [
                new((int)SaS2LootCategoryWeaponFields.FIELD_CLASS_LEVEL, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_PHYS_ATTACK, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_ELEM_ATTACK, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_BLOCK_DAMAGE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_BLOCK_STAMINA, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_REQ_STR, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_REQ_DEX, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_REQ_ARCANA, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_REQ_CONVICTION, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_REQ_LUCK, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_DARK_GLYPHS, (int)SaS2LootFieldDataType.DATA_TYPE_BOOLEAN),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_1, (int)SaS2LootFieldDataType.DATA_TYPE_MAGIC),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_1_CLASS, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_1_COST, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_1_COOLDOWN, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_2, (int)SaS2LootFieldDataType.DATA_TYPE_MAGIC),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_2_CLASS, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_2_COST, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_2_COOLDOWN, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_3, (int)SaS2LootFieldDataType.DATA_TYPE_MAGIC),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_3_CLASS, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_3_COST, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_3_COOLDOWN, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_STR_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_DEX_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_ARCANA_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_CONVICTION_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_LUCK_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_UPGRADE_SCALE, (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_BASE_UPGRADE, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_1, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_1_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_2, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_2_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_3, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_3_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT)
            ];
        }

        public override string GetFieldName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryWeaponFields.FIELD_BLOCK_STAMINA => "BlockStm(0-50):",
                (int)SaS2LootCategoryWeaponFields.FIELD_BLOCK_DAMAGE => "BlockDam(50-100):",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_1_COST => "Magic 1 Cost",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_2_COST => "Magic 2 Cost",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_3_COST => "Magic 3 Cost",
                (int)SaS2LootCategoryWeaponFields.FIELD_DARK_GLYPHS => "Dark Glyphs",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_1_CLASS => "Magic 1 Class",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_2_CLASS => "Magic 2 Class",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_3_CLASS => "Magic 3 Class",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_1_COOLDOWN => "Magic 1 Cooldown",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_2_COOLDOWN => "Magic 2 Cooldown",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_3_COOLDOWN => "Magic 3 Cooldown",
                (int)SaS2LootCategoryWeaponFields.FIELD_CLASS_LEVEL => "Class Level",
                (int)SaS2LootCategoryWeaponFields.FIELD_REQ_STR => "Req Str",
                (int)SaS2LootCategoryWeaponFields.FIELD_REQ_DEX => "Req Dex",
                (int)SaS2LootCategoryWeaponFields.FIELD_REQ_ARCANA => "Req Arcana",
                (int)SaS2LootCategoryWeaponFields.FIELD_REQ_CONVICTION => "Req Conv",
                (int)SaS2LootCategoryWeaponFields.FIELD_REQ_LUCK => "Req Luck",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_1 => "Magic [X]",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_2 => "Magic [Y]",
                (int)SaS2LootCategoryWeaponFields.FIELD_MAGIC_3 => "Magic [B]",
                (int)SaS2LootCategoryWeaponFields.FIELD_BASE_UPGRADE => "Base Upgrade",
                (int)SaS2LootCategoryWeaponFields.FIELD_UPGRADE_SCALE => "Upgrade Scale",
                (int)SaS2LootCategoryWeaponFields.FIELD_STR_SCALE => "Str Scale",
                (int)SaS2LootCategoryWeaponFields.FIELD_DEX_SCALE => "Dex Scale",
                (int)SaS2LootCategoryWeaponFields.FIELD_ARCANA_SCALE => "Arcana Scale",
                (int)SaS2LootCategoryWeaponFields.FIELD_LUCK_SCALE => "Luck Scale",
                (int)SaS2LootCategoryWeaponFields.FIELD_CONVICTION_SCALE => "Conv Scale",
                (int)SaS2LootCategoryWeaponFields.FIELD_PHYS_ATTACK => "Phys Atk",
                (int)SaS2LootCategoryWeaponFields.FIELD_ELEM_ATTACK => "Elem Percent",
                (int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_1 => "Crafting Loot 1",
                (int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_1_COUNT => "- Loot 1 Count",
                (int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_2 => "Crafting Loot 2",
                (int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_2_COUNT => "- Loot 2 Count",
                (int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_3 => "Crafting Loot 3",
                (int)SaS2LootCategoryWeaponFields.FIELD_CRAFTING_LOOT_3_COUNT => "- Loot 3 Count",

                _ => base.GetFieldName(idx),
            };
        }

        public override string GetSubtypeName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_SWITCHBLADE => "Switchblade",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_GREATSCISSORS => "Greatscissor",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_CHAINSWORD => "Chainsword",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_GUNBLADE => "Gunblade",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_SCYTHE => "Scythe",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_BOUND => "[bound]",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_ZWEIHANDER => "Zweihander",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_TRUEZWEI => "True Zwei",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_MACH_VANGUARD => "Mach Vanguard",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_STAVE => "Stave",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_GLAIVE => "Glaive",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_GREATBLADE => "Greatsword",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_HALFSPEAR => "Spear",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_VANGUARD => "Sword and Shield",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_AXE => "Axe",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_SPIN_DAGGERS => "Spin daggers",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_AXE_BLADE => "Axe/Blade",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_TWIN_DAGGERS => "Twin Daggers",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_GREATHAMMER => "Warhammer",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_WHIP => "Whip",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_KATANA => "Katana",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_RAPIER => "Rapier",
                (int)SaS2LootCategoryWeaponSubTypes.SUBTYPE_CHAIN_BLADE => "Chain Blade",

                _ => base.GetSubtypeName(idx),
            };
        }

        public override string GetFlagName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_GOLD => "Elem|Gold",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_TRAITOR => "Elem|Traitor",
                (int)SaS2LootCategoryWeaponFlags.FLAG_WIDE_GLAIVE => "-Wide Glaive",
                (int)SaS2LootCategoryWeaponFlags.FLAG_SLOWER_HITTER => "-Slower Hitter",
                (int)SaS2LootCategoryWeaponFlags.FLAG_FASTER_HITTER => "+Faster Hitter",
                (int)SaS2LootCategoryWeaponFlags.FLAG_LONG_SLIDE => "+Long Slide",
                (int)SaS2LootCategoryWeaponFlags.FLAG_SLOW_HITTER => "-Slow Hitter",
                (int)SaS2LootCategoryWeaponFlags.FLAG_FAST_HITTER => "+Fast Hitter",
                (int)SaS2LootCategoryWeaponFlags.FLAG_EXTRA_POISE_DMG => "+Extra Poise Dmg",
                (int)SaS2LootCategoryWeaponFlags.FLAG_LESS_POISE_DMG => "-Less Poise Dmg",
                (int)SaS2LootCategoryWeaponFlags.FLAG_SLIDE => "+Slide",
                (int)SaS2LootCategoryWeaponFlags.FLAG_EXTRA_STAMINA_COST => "-Extra Stamina Cost",
                (int)SaS2LootCategoryWeaponFlags.FLAG_LESS_STAMINA_COST => "+Less Stamina Cost",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_BLUEHEART => "Elem|Blueheart",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_DAWNLIGHT => "Elem|Dawnlight",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_CHAOS => "Elem|Chaos",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_OATH => "Elem|Oath",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_SHROUD => "Elem|Shroud",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_SHERIFF => "Elem|Sheriff",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_BLUE_DRAGON => "Elem|Blue Dragon",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_HAG => "Elem|Hag",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_MUMMY => "Elem|Mummy",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_SKY => "Elem|Sky",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_OWL => "Elem|Owl",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_RED_FIRE => "Elem|Red Fire",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_RED_LIT => "Elem|Red Lit",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_MESSIAH => "Elem|Messiah",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_GHOST => "Elem|Ghost",
                (int)SaS2LootCategoryWeaponFlags.FLAG_CHAIN_WHIP => "Chain Whip",
                (int)SaS2LootCategoryWeaponFlags.FLAG_SIDE_ATTACH => "Side Attach",
                (int)SaS2LootCategoryWeaponFlags.FLAG_BLUDGEON_MEGA => "Bludgeon Mega",
                (int)SaS2LootCategoryWeaponFlags.FLAG_BLUDGEON_PARTIAL => "Bludgeon Partial",
                (int)SaS2LootCategoryWeaponFlags.FLAG_BLUDGEON_FULL => "Bludgeon Full",
                (int)SaS2LootCategoryWeaponFlags.FLAG_RAGE => "Rage",
                (int)SaS2LootCategoryWeaponFlags.FLAG_MP => "MP",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_FIRE => "Elem|Fire",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_WATER => "Elem|Water",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_LIT => "Elem|Lit",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_POISON => "Elem|Poison",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_EARTH => "Elem|Earth",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_TIME => "Elem|Time",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_FLESH => "Elem|Flesh",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_FUNGUS => "Elem|Fungus",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_MECH => "Elem|Mech",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_DEMON => "Elem|Demon",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_DRAGON => "Elem|Dragon",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_BOOKS => "Elem|Books",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_AIR => "Elem|Air",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_ICE => "Elem|Ice",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_FORCE => "Elem|Force",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_DIVINE => "Elem|Divine",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_LIGHT => "Elem|Light",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_BLOOD => "Elem|Blood",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_UNDEAD => "Elem|Undead",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_MIND => "Elem|Mind",
                (int)SaS2LootCategoryWeaponFlags.FLAG_ELEM_DARK => "Elem|Dark",

                _ => base.GetFlagName(idx),
            };
        }

        public override int GetSubtypeCount()
        {
            return (int)SaS2LootCategoryWeaponSubTypes.TotalCount;
        }

        public override int GetFlagCount()
        {
            return (int)SaS2LootCategoryWeaponFlags.TotalCount;
        }
    }
}
