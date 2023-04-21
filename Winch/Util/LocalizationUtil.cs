﻿using System.Collections.Generic;

namespace Winch.Util
{
    public static class LocalizationUtil
    {
        private static Dictionary<string, Dictionary<string, string>> StringDatabase = new Dictionary<string, Dictionary<string, string>>();

        public static void AddLocalizedString(string locale, string key, string value)
        {
            if(!StringDatabase.ContainsKey(locale))
                StringDatabase[locale] = new Dictionary<string, string>();
            StringDatabase[locale][key] = value;
        }

        public static string GetLocalizedString(string locale, string key)
        {
            if (!StringDatabase.ContainsKey(locale)) return null;
            if (!StringDatabase[locale].ContainsKey(key)) return null;
            return StringDatabase[locale][key];
        }
    }
}
