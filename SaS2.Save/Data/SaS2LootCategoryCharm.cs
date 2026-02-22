using static SaS2.Save.SaS2LootField;

namespace SaS2.Save
{
    public class SaS2LootCategoryCharm : SaS2LootCategory
    {
        public enum SaS2LootCategoryCharmFields
        {
            FIELD_CRAFTING_LOOT_1 = 0,
            FIELD_CRAFTING_LOOT_1_COUNT = 1,
            FIELD_CRAFTING_LOOT_2 = 2,
            FIELD_CRAFTING_LOOT_2_COUNT = 3,
            FIELD_CRAFTING_LOOT_3 = 4,
            FIELD_CRAFTING_LOOT_3_COUNT = 5,

            TotalCount
        }

        public enum SaS2LootCategoryCharmFlags
        {
            FLAG_PHYS_DEF = 0,
            FLAG_FIRE_DEF = 1,
            FLAG_COLD_DEF = 2,
            FLAG_POISON_DEF = 3,
            FLAG_LIGHT_DEF = 4,
            FLAG_DARK_DEF = 5,
            FLAG_ITEM_FIND = 6,
            FLAG_FOCUS_GAIN = 7,
            FLAG_FOCUS_WINDOW = 8,
            FLAG_WOOD_RUNES = 9,
            FLAG_POISE = 10,
            FLAG_SPIDER = 11,
            FLAG_STAMINA_REGEN = 12,
            FLAG_SILVER_FIND = 13,
            FLAG_DAMAGE = 14,
            FLAG_GOLD = 15,
            FLAG_FIRE_ATK = 16,
            FLAG_COLD_ATK = 17,
            FLAG_POISON_ATK = 18,
            FLAG_LIGHT_ATK = 19,
            FLAG_DARK_ATK = 20,
            FLAG_MULTIPLAYER_SEARCHING = 21,
            FLAG_MULTIPLAYER_DAWNLIGHT = 22,
            FLAG_MULTIPLAYER_BLUEHEART = 23,
            FLAG_MULTIPLAYER_OATH = 24,
            FLAG_MULTIPLAYER_SHROUD = 25,
            FLAG_MULTIPLAYER_SHERIFF = 26,
            FLAG_MULTIPLAYER_CHAOS = 27,
            FLAG_MULTIPLAYER_SHADOW = 28,
            FLAG_CARRY_WEIGHT = 29,
            FLAG_HP_KILL_GAIN = 30,
            FLAG_MP_KILL_GAIN = 31,
            FLAG_PARRY_STAGGER_DAMAGE = 32,
            FLAG_MP_REGAIN = 33,
            FLAG_RIPOSTE_DMG = 34,
            FLAG_DYING_BOOST = 35,
            FLAG_HP_BOOST = 36,
            FLAG_RAGE_BOOST = 37,
            FLAG_MP_BOOST = 38,
            FLAG_SP_BOOST = 39,
            FLAG_MP_PARRY_REGAIN = 40,
            FLAG_HP_PARRY_REGAIN = 41,
            FLAG_MP_RIPOSTE_REGAIN = 42,
            FLAG_HP_RIPOSTE_REGAIN = 43,
            FLAG_RESTOCK_SPEED = 44,
            FLAG_RAGE_PARRY_REGAIN = 45,
            FLAG_RAGE_RIPOSTE_REGAIN = 46,
            FLAG_STAMINA_COVERAGE = 47,
            FLAG_BLOCKING_STAMINA_CHEAP = 48,
            FLAG_RUNIC_ART_BOOST = 49,
            FLAG_FASTER_DRINKING = 50,
            FLAG_DEFENSE_OVERALL = 51,
            FLAG_HAZE_HP = 52,
            FLAG_HAZE_MP = 53,
            FLAG_HAZE_RAGE = 54,

            TotalCount
        }

        public enum SaS2LootCategoryCharmSubTypes
        {
            SUBTYPE_RING = 0,
            SUBTYPE_AMULET = 1,
            SUBTYPE_DAGGER = 2,
            SUBTYPE_ARTIFACT_ATTACK = 3,
            SUBTYPE_ARTIFACT_DEFENSE = 4,
            SUBTYPE_ARTIFACT_UTILITY = 5,
            SUBTYPE_TROPHY = 6,

            TotalCount
        }

        public override List<SaS2LootField> CreateFields()
        {
            return
            [
                new((int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_1, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_1_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_2, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_2_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_3, (int)SaS2LootFieldDataType.DATA_TYPE_LOOT),
                new((int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_3_COUNT, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
            ];
        }

        public override string GetFieldName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_1 => "Crafting Loot 1",
                (int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_1_COUNT => "- Loot 1 Count",
                (int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_2 => "Crafting Loot 2",
                (int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_2_COUNT => "- Loot 2 Count",
                (int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_3 => "Crafting Loot 3",
                (int)SaS2LootCategoryCharmFields.FIELD_CRAFTING_LOOT_3_COUNT => "- Loot 3 Count",

                _ => base.GetFieldName(idx),
            };
        }

        public override string GetSubtypeName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_RING => "Ring",
                (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_AMULET => "Amulet",
                (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_DAGGER => "Dagger",
                (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_ARTIFACT_ATTACK => "Artifact (Attack)",
                (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_ARTIFACT_DEFENSE => "Artifact (Defense)",
                (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_ARTIFACT_UTILITY => "Artifact (Utility)",
                (int)SaS2LootCategoryCharmSubTypes.SUBTYPE_TROPHY => "Trophy",

                _ => base.GetSubtypeName(idx),
            };
        }

        public override int GetSubtypeCount()
        {
            return (int)SaS2LootCategoryCharmSubTypes.TotalCount;
        }

        public override string GetFlagName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryCharmFlags.FLAG_HAZE_HP => "Haze HP",
                (int)SaS2LootCategoryCharmFlags.FLAG_HAZE_MP => "Haze MP",
                (int)SaS2LootCategoryCharmFlags.FLAG_HAZE_RAGE => "Haze Rage",
                (int)SaS2LootCategoryCharmFlags.FLAG_DEFENSE_OVERALL => "Overall defense",
                (int)SaS2LootCategoryCharmFlags.FLAG_FASTER_DRINKING => "Faster Drinking",
                (int)SaS2LootCategoryCharmFlags.FLAG_RUNIC_ART_BOOST => "Runic art boost",
                (int)SaS2LootCategoryCharmFlags.FLAG_BLOCKING_STAMINA_CHEAP => "Blocking stamina cheap",
                (int)SaS2LootCategoryCharmFlags.FLAG_STAMINA_COVERAGE => "Stamina coverage",
                (int)SaS2LootCategoryCharmFlags.FLAG_RAGE_PARRY_REGAIN => "Rage Parry regain",
                (int)SaS2LootCategoryCharmFlags.FLAG_RAGE_RIPOSTE_REGAIN => "Rage Riposte regain",
                (int)SaS2LootCategoryCharmFlags.FLAG_RESTOCK_SPEED => "Restock speed",
                (int)SaS2LootCategoryCharmFlags.FLAG_MP_PARRY_REGAIN => "MP Parry regain",
                (int)SaS2LootCategoryCharmFlags.FLAG_HP_PARRY_REGAIN => "HP Parry regain",
                (int)SaS2LootCategoryCharmFlags.FLAG_MP_RIPOSTE_REGAIN => "MP Riposte regain",
                (int)SaS2LootCategoryCharmFlags.FLAG_HP_RIPOSTE_REGAIN => "HP Riposte regain",
                (int)SaS2LootCategoryCharmFlags.FLAG_SP_BOOST => "Max Stamina Boost",
                (int)SaS2LootCategoryCharmFlags.FLAG_HP_BOOST => "Max HP Boost",
                (int)SaS2LootCategoryCharmFlags.FLAG_MP_BOOST => "Max MP Boost",
                (int)SaS2LootCategoryCharmFlags.FLAG_RAGE_BOOST => "Max Rage Boost",
                (int)SaS2LootCategoryCharmFlags.FLAG_DYING_BOOST => "Dying Boost",
                (int)SaS2LootCategoryCharmFlags.FLAG_RIPOSTE_DMG => "Riposte Dmg",
                (int)SaS2LootCategoryCharmFlags.FLAG_MP_REGAIN => "MP Regain",
                (int)SaS2LootCategoryCharmFlags.FLAG_MULTIPLAYER_SHADOW => "Multiplayer|Shadow",
                (int)SaS2LootCategoryCharmFlags.FLAG_MULTIPLAYER_SEARCHING => "Multiplayer|Searching",
                (int)SaS2LootCategoryCharmFlags.FLAG_MULTIPLAYER_DAWNLIGHT => "Multiplayer|Dawnlight",
                (int)SaS2LootCategoryCharmFlags.FLAG_MULTIPLAYER_BLUEHEART => "Multiplayer|Blueheart",
                (int)SaS2LootCategoryCharmFlags.FLAG_MULTIPLAYER_OATH => "Multiplayer|Oathbound",
                (int)SaS2LootCategoryCharmFlags.FLAG_MULTIPLAYER_SHROUD => "Multiplayer|Shroud",
                (int)SaS2LootCategoryCharmFlags.FLAG_MULTIPLAYER_SHERIFF => "Multiplayer|Sheriff",
                (int)SaS2LootCategoryCharmFlags.FLAG_MULTIPLAYER_CHAOS => "Multiplayer|Chaos",
                (int)SaS2LootCategoryCharmFlags.FLAG_CARRY_WEIGHT => "Carry Weight",
                (int)SaS2LootCategoryCharmFlags.FLAG_HP_KILL_GAIN => "HP Kill Gain",
                (int)SaS2LootCategoryCharmFlags.FLAG_MP_KILL_GAIN => "MP Kill Gain",
                (int)SaS2LootCategoryCharmFlags.FLAG_PARRY_STAGGER_DAMAGE => "Parry Stagger Damage",
                (int)SaS2LootCategoryCharmFlags.FLAG_FIRE_ATK => "Fire Atk",
                (int)SaS2LootCategoryCharmFlags.FLAG_COLD_ATK => "Cold Atk",
                (int)SaS2LootCategoryCharmFlags.FLAG_POISON_ATK => "Poison Atk",
                (int)SaS2LootCategoryCharmFlags.FLAG_LIGHT_ATK => "Light Atk",
                (int)SaS2LootCategoryCharmFlags.FLAG_DARK_ATK => "Dark Atk",
                (int)SaS2LootCategoryCharmFlags.FLAG_POISE => "Poise",
                (int)SaS2LootCategoryCharmFlags.FLAG_GOLD => "Gold",
                (int)SaS2LootCategoryCharmFlags.FLAG_DAMAGE => "Damage",
                (int)SaS2LootCategoryCharmFlags.FLAG_SILVER_FIND => "Silver Find",
                (int)SaS2LootCategoryCharmFlags.FLAG_STAMINA_REGEN => "Stamina Regen",
                (int)SaS2LootCategoryCharmFlags.FLAG_SPIDER => "Fast grapple/climb",
                (int)SaS2LootCategoryCharmFlags.FLAG_WOOD_RUNES => "Wood Runes",
                (int)SaS2LootCategoryCharmFlags.FLAG_FOCUS_GAIN => "Rage Gain",
                (int)SaS2LootCategoryCharmFlags.FLAG_FOCUS_WINDOW => "Rage Window",
                (int)SaS2LootCategoryCharmFlags.FLAG_PHYS_DEF => "Phys Def",
                (int)SaS2LootCategoryCharmFlags.FLAG_FIRE_DEF => "Fire Def",
                (int)SaS2LootCategoryCharmFlags.FLAG_COLD_DEF => "Cold Def",
                (int)SaS2LootCategoryCharmFlags.FLAG_POISON_DEF => "Poison Def",
                (int)SaS2LootCategoryCharmFlags.FLAG_LIGHT_DEF => "Light Def",
                (int)SaS2LootCategoryCharmFlags.FLAG_DARK_DEF => "Dark Def",
                (int)SaS2LootCategoryCharmFlags.FLAG_ITEM_FIND => "Item Find",

                _ => base.GetFlagName(idx),
            };
        }

        public override int GetFlagCount()
        {
            return (int)SaS2LootCategoryCharmFlags.TotalCount;
        }

        public override int GetFieldsCount()
        {
            return (int)SaS2LootCategoryCharmFields.TotalCount;
        }
    }
}
