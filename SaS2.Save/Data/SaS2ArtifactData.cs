namespace SaS2.Save.Data
{
    public class SaS2ArtifactData
    {
        public float[] value;

        public enum SaS2ArtifactDataFileds
        {
            FIELD_ATTACK_DAMAGE = 0,
            FIELD_ATTACK_SPEED = 1,
            FIELD_ATTACK_POISE_DMG = 2,
            FIELD_ATTACK_STAMINA_REDUCTION = 3,
            FIELD_ATTACK_DAMAGE_VS_MAGES = 4,
            FIELD_ATTACK_DAMAGE_VS_MINIONS = 5,
            FIELD_ATTACK_DAMAGE_VS_UNDEAD = 6,
            FIELD_ATTACK_DAMAGE_VS_MOBS = 7,
            FIELD_ATTACK_DAMAGE_VS_GUARDIANS = 8,
            FIELD_ATTACK_DAMAGE_VS_HAZEBURNT = 9,
            FIELD_ATTACK_RAGE_BUILDUP = 10,
            FIELD_ATTACK_REACH = 11,
            FIELD_ATTACK_DAMAGE_VS_PLAYERS = 12,
            FIELD_DEFENSE_ADD_HP = 13,
            FIELD_DEFENSE_ADD_MP = 14,
            FIELD_DEFENSE_ADD_STAMINA = 15,
            FIELD_DEFENSE_REDUCE_DAMAGE_RECEIVED = 16,
            FIELD_DEFENSE_ADD_STAMINA_RECOVER = 17,
            FIELD_DEFENSE_PHYS = 18,
            FIELD_DEFENSE_FIRE = 19,
            FIELD_DEFENSE_COLD = 20,
            FIELD_DEFENSE_POISON = 21,
            FIELD_DEFENSE_LIGHT = 22,
            FIELD_DEFENSE_DARK = 23,
            FIELD_DEFENSE_POISE_RECOVERY = 24,
            FIELD_DEFENSE_POISE = 25,
            FIELD_UTILITY_RANGED_DMG = 26,
            FIELD_UTILITY_FREE_AMMO = 27,
            FIELD_UTILITY_ITEM_FIND = 28,
            FIELD_UTILITY_SILVER_FIND = 29,
            FIELD_UTILITY_XP_FIND = 30,
            FIELD_UTILITY_SILVER_SAVE = 31,
            FIELD_UTILITY_XP_SAVE = 32,
            FIELD_UTILITY_ALCHEMY_DMG = 33,
            FIELD_UTILITY_RUNIC_ATTACK = 34,

            TotalCount
        }

        public const int TIER_MULTIPLIER = 2000;
        public const int MAX_TIER = 100;

        public SaS2ArtifactData()
        {
            value = new float[(int)SaS2ArtifactDataFileds.TotalCount];
        }
    }
}
