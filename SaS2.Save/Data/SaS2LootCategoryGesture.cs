using static SaS2.Save.SaS2LootField;

namespace SaS2.Save
{
    public class SaS2LootCategoryGesture : SaS2LootCategory
    {
        public enum SaS2LootCategoryGestureFields
        {
            FIELD_ANIMATION = 0,

            TotalCount
        }

        public enum SaS2LootCategoryGestureFlags
        {
            FLAG_COOP = 0,
            FLAG_FRIENDLY = 1,
            FLAG_ANGRY = 2,
            FLAG_NEUTRAL = 3,

            TotalCount
        }

        public override List<SaS2LootField> CreateFields()
        {
            return
            [
                new((int)SaS2LootCategoryGestureFields.FIELD_ANIMATION, (int)SaS2LootFieldDataType.DATA_TYPE_ANIMATION),
            ];
        }

        public override string GetFieldName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryGestureFields.FIELD_ANIMATION => "Animation",

                _ => base.GetFieldName(idx)
            };
        }

        public override int GetFlagCount()
        {
            return (int)SaS2LootCategoryGestureFlags.TotalCount;
        }

        public override string GetFlagName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryGestureFlags.FLAG_NEUTRAL => "Neutral",
                (int)SaS2LootCategoryGestureFlags.FLAG_COOP => "Coop",
                (int)SaS2LootCategoryGestureFlags.FLAG_FRIENDLY => "Friendly",
                (int)SaS2LootCategoryGestureFlags.FLAG_ANGRY => "Angry",

                _ => base.GetFlagName(idx),
            };
        }

        public override int GetFieldsCount()
        {
            return (int)SaS2LootCategoryGestureFields.TotalCount;
        }
    }
}
