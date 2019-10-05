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
        public static string ToSlug(this string s)
        {
            string str = s.ToLower();
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
    }
}
