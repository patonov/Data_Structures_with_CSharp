using System;
using System.Collections.Generic;
using System.Text;

namespace EnBgStaticDictionaryTranslater
{
    public static class EnBgTranslate
    {
        static Dictionary<string, string> dict = new Dictionary<string, string>() { 
        {"translate", "превеждам"},
        {"image", "изображение"},
        {"picture", "картина"},
        {"great", "велик"},
        {"option", "опция"},
        {"car", "кола"},
        {"homosexual", "хомосексуалист"},
        {"inflation", "инфлация"},
        {"multiplier", "мултипликатор"},
        {"fiscal", "фискален"},
        {"digital", "цифров"}
    };

        public static string Translaing(string word)
        {
            string result = string.Empty;

            if (dict.TryGetValue(word, out result))
            {
                return result;
            }
            else
            {
                return "out of our dictionary.";
            }

        }
    }
}
