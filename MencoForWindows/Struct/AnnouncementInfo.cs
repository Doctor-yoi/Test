using System;
using System.Collections.Generic;

using static MencoForWindows.Utils.TextUtil;

namespace MencoForWindows.Struct
{
    [Serializable]
    public class AnnouncementInfo
    {
        public string userName = "DefaultUser";
        public bool isTopup = false;
        public string uploadTime = "1970-01-01 00:00:00";
        public string text = "";
        public List<Uri> originPhotoUrl = new List<Uri> { };
        public List<Uri> thumbnailPhotoUrl = new List<Uri> { };
        
        public AnnouncementInfo(
            string userName,
            bool isTopup,
            string uploadTime,
            string originText,
            List<Uri> originPhotoUrlList,
            List<Uri> thumbnailPhotoUrl)
        {
            this.userName = userName;
            this.isTopup = isTopup;
            this.uploadTime = uploadTime;
            this.text = parseText(originText);

        }

        
    }
}
