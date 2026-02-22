using static SaS2.Save.SaS2LootField;

namespace SaS2.Save
{
    public class SaS2LootCategoryMaterial : SaS2LootCategory
    {
        public enum SaS2LootCategoryMaterialFlags
        {
            FLAG_RARE = 0,
            FLAG_VERY_RARE = 1,
            FLAG_LEGENDARY = 2,
            FLAG_EPIC = 3,
            FLAG_BLACK_PEARL = 4,
            FLAG_GRAY_PEARL = 5,
            FLAG_ELEM_PHYS = 6,
            FLAG_ELEM_FIRE = 7,
            FLAG_ELEM_COLD = 8,
            FLAG_ELEM_POISON = 9,
            FLAG_ELEM_LIGHT = 10,
            FLAG_ELEM_DARK = 11,

            TotalCount
        }

        public enum SaS2LootCategoryMaterialFields
        {
            FIELD_SILVER_MIN = 0,
            FIELD_SILVER_MAX = 1,
            FIELD_INVENTORY_MAX = 2,

            TotalCount
        }

        public override List<SaS2LootField> CreateFields()
        {
            return
            [
                new((int)SaS2LootCategoryMaterialFields.FIELD_INVENTORY_MAX, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryMaterialFields.FIELD_SILVER_MIN, (int)SaS2LootFieldDataType.DATA_TYPE_INT),
                new((int)SaS2LootCategoryMaterialFields.FIELD_SILVER_MAX, (int)SaS2LootFieldDataType.DATA_TYPE_INT)
            ];
        }

        public override string GetFieldName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryMaterialFields.FIELD_INVENTORY_MAX => "Inventory Max:",
                (int)SaS2LootCategoryMaterialFields.FIELD_SILVER_MIN => "Silver Min:",
                (int)SaS2LootCategoryMaterialFields.FIELD_SILVER_MAX => "Silver Max:",

                _ => "Undefined field",
            };
        }

        public override string GetFlagName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryMaterialFlags.FLAG_ELEM_PHYS => "Elem|Phys",
                (int)SaS2LootCategoryMaterialFlags.FLAG_ELEM_FIRE => "Elem|Fire",
                (int)SaS2LootCategoryMaterialFlags.FLAG_ELEM_COLD => "Elem|Cold",
                (int)SaS2LootCategoryMaterialFlags.FLAG_ELEM_POISON => "Elem|Poison",
                (int)SaS2LootCategoryMaterialFlags.FLAG_ELEM_LIGHT => "Elem|Light",
                (int)SaS2LootCategoryMaterialFlags.FLAG_ELEM_DARK => "Elem|Dark",
                (int)SaS2LootCategoryMaterialFlags.FLAG_BLACK_PEARL => "Black Pearl",
                (int)SaS2LootCategoryMaterialFlags.FLAG_GRAY_PEARL => "Gray Pearl",
                (int)SaS2LootCategoryMaterialFlags.FLAG_RARE => "Rare",
                (int)SaS2LootCategoryMaterialFlags.FLAG_VERY_RARE => "Very Rare",
                (int)SaS2LootCategoryMaterialFlags.FLAG_LEGENDARY => "Legendary",
                (int)SaS2LootCategoryMaterialFlags.FLAG_EPIC => "Epic",

                _ => base.GetFlagName(idx),
            };
        }

        public override int GetFlagCount()
        {
            return (int)SaS2LootCategoryMaterialFlags.TotalCount;
        }

        public override int GetFieldsCount()
        {
            return (int)SaS2LootCategoryMaterialFields.TotalCount;
        }

        public override int GetMaxCount(List<SaS2LootField> fields)
        {
            var field = fields.Find(field => field.ID == (int)SaS2LootCategoryMaterialFields.FIELD_INVENTORY_MAX);

            if (field == null || field.iData == 0)
            {
                return 99;
            }

            return field.iData;
        }
    }
}
