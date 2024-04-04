using System.Collections.Generic;

using Microsoft.UI.Xaml.Media.Imaging;

namespace mencoForWindows_winui3.Models
{
    public class PostContent
    {
        public PostContent()
        {

        }

        public string authorName;
        public BitmapImage authorIcon;
        public string updateTime;
        public string content;
        public int likedCount;
        public int commentCount;
        public List<Dictionary<BitmapImage, string[]>> resources;
    }
}
