using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBlog.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLength = 100)
        {
            if (text == null || text.Length <= maxLength)
                return text;
            
            var shortText = text.Substring(0, maxLength) + "...";
            return shortText;
        }

        public static string CutAccountName(string text, int maxLength = 10)
        {
            var nameWithoutEmail = text.Substring(0, text.IndexOf('@'));
            if (text == null || text.Length <= maxLength)
            {
                return nameWithoutEmail;
            }
            if (nameWithoutEmail.Length>=maxLength)
            {
                var shortText = nameWithoutEmail.Substring(0, maxLength) + "...";
                return shortText;
            }
            if (nameWithoutEmail.Length < maxLength)
            {
                return nameWithoutEmail;
            }           
            return null;
        }
    }
}