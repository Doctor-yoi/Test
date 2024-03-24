using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
