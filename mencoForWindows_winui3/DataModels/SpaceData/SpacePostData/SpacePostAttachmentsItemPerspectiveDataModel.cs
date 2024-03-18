using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
    public class SpacePostAttachmentsItemPerspectiveDataModel
    {
        [JsonPropertyName("liked")]
        public bool Liked;
    }
}
