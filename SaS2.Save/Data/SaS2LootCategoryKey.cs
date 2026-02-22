namespace SaS2.Save
{
    public class SaS2LootCategoryKey : SaS2LootCategory
    {
        public enum SaS2LootCategoryKeyFlags
        {
            FLAG_STARTING_CLASS = 0,
            FLAG_TOME = 1,

            TotalCount
        }

        public override string GetFlagName(int idx)
        {
            return idx switch
            {
                (int)SaS2LootCategoryKeyFlags.FLAG_TOME => "Tome",
                (int)SaS2LootCategoryKeyFlags.FLAG_STARTING_CLASS => "Starting Class",

                _ => base.GetFlagName(idx),
            };
        }

        public override int GetFlagCount()
        {
            return (int)SaS2LootCategoryKeyFlags.TotalCount;
        }
    }
}
