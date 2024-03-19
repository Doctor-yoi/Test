using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mencoForWindows_winui3.Utils
{
    public static class TextUtil
    {
        public static string parseText(string originText)
        {
            originText = originText.Replace("\\n", "&#x0D;");
            string pattern = @"(https?://\S+)";
            string replacement = @"<Hyperlink NavigateUri=""$1"" RequestNavigate=""Hyperlink_RequestNavigate"">$1</Hyperlink>";
            string result = Regex.Replace(originText, pattern, replacement);
            return result;
        }
    }
}
