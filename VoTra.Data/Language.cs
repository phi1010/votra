using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhillipKuhrt.VoTra.Data
{
    public enum Language
    {
        /// <summary>
        /// Fremdsprache
        /// </summary>
        OtherLanguage,
        /// <summary>
        /// Deutsch
        /// </summary>
        German
    }
    public static class LanguageExtension
    {
        public static Language GetOther(this Language lang)
        {
            if (lang == Language.German)
                return Language.OtherLanguage;
            else
                return Language.German;
        }
    }
}
