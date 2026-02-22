using SaS2.Save.Data;

namespace SaS2.Save
{
    public static class SaS2Environment
    {
        public static Language currentLanguage = GetDefaultLanguage();

        public static Language GetDefaultLanguage()
        {
            return Language.English;
        }
    }
}
