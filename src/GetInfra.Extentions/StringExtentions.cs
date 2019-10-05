using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace GetInfra.Extentions
{
    public static class StringExtentions
    {
        /// <summary>
        /// converting string to urls, filenames and ids
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>")]
        public static string ToSlug(this string s)
        {
            if (string.IsNullOrEmpty(s)) throw new ArgumentNullException(nameof(s));

            string str = s.ToLowerInvariant();
            // remove invalid chars          
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            // hyphens  
            str = Regex.Replace(str, @"\s", "-"); 
            
            return str;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsSlug(this string s)
        {
            if (string.IsNullOrEmpty(s)) throw new ArgumentNullException(nameof(s));

            // 
            if (Regex.IsMatch(s, @"^[a-z0-9-]+$"))
                return true;
            return false;
        }
    }
}
