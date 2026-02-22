namespace SaS2.Save
{
    public class SaS2LootCategoryMagic : SaS2LootCategory
    {
        public enum SaS2LootCategoryMagicFields
        {
            FIELD_COST = 0,
            FIELD_MAGIC = 1,
            FIELD_CLASS = 2,
            FIELD_COOLDOWN = 3,

            TotalCount
        }

        public enum SaS2LootCategoryMagicMagics
        {
            MAGIC_AMP = 0,
            MAGIC_ELEM = 1,
            MAGIC_CURE = 2,
            MAGIC_WAVE = 3,
            MAGIC_ORBITS = 4,
            MAGIC_TURRET = 5,
            MAGIC_ANTIDOTE = 6,
            MAGIC_RESISTANCE = 7,
            MAGIC_EXPLOSION = 8,
            MAGIC_COLUMN = 9,
            MAGIC_BLESS = 10,
            MAGIC_ORBS = 11,
            MAGIC_SEEKERS = 12,

            TotalCount
        }

        public enum SaS2LootCategoryMagicFlags
        {
            FLAG_RAGE_TYPE = 0,
            FLAG_MP_TYPE = 1,

            TotalCount
        }

        public override List<SaS2LootField> CreateFields()
        {
            return
            [
                new((int)SaS2LootCategoryMagicFields.FIELD_COST, 0),
                new((int)SaS2LootCategoryMagicFields.FIELD_MAGIC, 6),
                new((int)SaS2LootCategoryMagicFields.FIELD_COOLDOWN, 2),
                new((int)SaS2LootCategoryMagicFields.FIELD_CLASS, 2)
            ];
        }

        public override int GetFlagCount()
        {
            return (int)SaS2LootCategoryMagicFlags.TotalCount;
        }

        public override string GetFlagName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryMagicFlags.FLAG_RAGE_TYPE => "Rage Type",
                (int)SaS2LootCategoryMagicFlags.FLAG_MP_TYPE => "MP Type",

                _ => base.GetFlagName(idx),
            };
        }

        public static int GetMagicIdxFromName(string name)
        {
            for (int i = 0; i < (int)SaS2LootCategoryMagicMagics.TotalCount; i++)
            {
                if (GetMagicName(i) == name)
                {
                    return i;
                }
            }

            return 0;
        }

        public static string GetMagicName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryMagicMagics.MAGIC_AMP => "Amp",
                (int)SaS2LootCategoryMagicMagics.MAGIC_ELEM => "Elem",
                (int)SaS2LootCategoryMagicMagics.MAGIC_CURE => "Cure",
                (int)SaS2LootCategoryMagicMagics.MAGIC_WAVE => "Wave",
                (int)SaS2LootCategoryMagicMagics.MAGIC_ORBITS => "Orbits",
                (int)SaS2LootCategoryMagicMagics.MAGIC_TURRET => "Turret",
                (int)SaS2LootCategoryMagicMagics.MAGIC_ANTIDOTE => "Antidote",
                (int)SaS2LootCategoryMagicMagics.MAGIC_RESISTANCE => "Resistance",
                (int)SaS2LootCategoryMagicMagics.MAGIC_EXPLOSION => "Explosion",
                (int)SaS2LootCategoryMagicMagics.MAGIC_COLUMN => "Column",
                (int)SaS2LootCategoryMagicMagics.MAGIC_BLESS => "Bless",
                (int)SaS2LootCategoryMagicMagics.MAGIC_ORBS => "Orbs",
                (int)SaS2LootCategoryMagicMagics.MAGIC_SEEKERS => "Seekers",

                _ => "Unnamed Magic",
            };
        }

        public override string GetFieldName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryMagicFields.FIELD_COOLDOWN => "Cooldown",
                (int)SaS2LootCategoryMagicFields.FIELD_CLASS => "Class",
                (int)SaS2LootCategoryMagicFields.FIELD_COST => "Cost",
                (int)SaS2LootCategoryMagicFields.FIELD_MAGIC => "Magic",

                _ => base.GetFieldName(idx),
            };
        }

        public override int GetFieldsCount()
        {
            return (int)SaS2LootCategoryMagicFields.TotalCount;
        }
    }
}
