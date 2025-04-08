using UnityEngine;

namespace Core.Common
{
    public static class Language
    {
        public static string Code;
        public const string EnglishCode = "en";
        public const string RussianCode = "ru";
        
        private const string PlayerPrefsKey = "APP_LANGUAGE";

        public static void Initialize()
        {
            if (!PlayerPrefs.HasKey(PlayerPrefsKey))
            {
                SetLanguage(GetDefaultLanguageCode());
                return;
            }
        
            Code = PlayerPrefs.GetString(PlayerPrefsKey);
        }
        public static void SetLanguage(string strLang)
        {
            Code = strLang;
            PlayerPrefs.SetString(PlayerPrefsKey, Code);
            PlayerPrefs.Save();
        }

        private static string GetDefaultLanguageCode()
        {
            return Application.systemLanguage switch
            {
                SystemLanguage.Russian => RussianCode,
                _ => EnglishCode
            };
        }
    }
}
