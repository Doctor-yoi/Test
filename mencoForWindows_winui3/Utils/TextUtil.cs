using System.Text.RegularExpressions;

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
