namespace SaS2.Save
{
    public class SaS2LootCategory
    {
        public enum SaS2LootCategoryType
        {
            TYPE_ARMOR = 0,
            TYPE_WEAPON = 1,
            TYPE_RANGED = 2,
            TYPE_CONSUMABLE = 3,
            TYPE_MATERIAL = 4,
            TYPE_KEY = 5,
            TYPE_CHARM = 6,
            TYPE_MAGIC = 7,
            TYPE_GESTURE = 8,

            TotalCount,
        }

        public virtual List<SaS2LootField> CreateFields()
        {
            return [];
        }
        public virtual string GetFieldName(int idx)
        {
            return "Undefined Field";
        }

        public virtual string GetSubtypeName(int idx)
        {
            return "Undefined Subtype";
        }
        public virtual string GetFlagName(int idx)
        {
            return "Undefined Flag";
        }

        public static string GetTypeName(int type)
        {
            return type switch
            {
                (int)SaS2LootCategoryType.TYPE_ARMOR => "Armor",
                (int)SaS2LootCategoryType.TYPE_WEAPON => "Weapon",
                (int)SaS2LootCategoryType.TYPE_RANGED => "Ranged",
                (int)SaS2LootCategoryType.TYPE_CONSUMABLE => "Consumable",
                (int)SaS2LootCategoryType.TYPE_MATERIAL => "Material",
                (int)SaS2LootCategoryType.TYPE_KEY => "Key",
                (int)SaS2LootCategoryType.TYPE_CHARM => "Charm",
                (int)SaS2LootCategoryType.TYPE_MAGIC => "Magic",
                (int)SaS2LootCategoryType.TYPE_GESTURE => "Gesture",

                _ => "Undefined Type",
            };
        }

        public virtual int GetFieldsCount()
        {
            return 0;
        }

        public virtual int GetSubtypeCount()
        {
            return 0;
        }

        public virtual int GetFlagCount()
        {
            return 0;
        }

        public virtual int GetMaxCount(List<SaS2LootField> fields)
        {
            return 1;
        }
    }
}
