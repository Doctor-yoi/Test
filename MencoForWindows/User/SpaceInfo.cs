using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MencoForWindows.User
{
    public class SpaceInfo
    {
        public SpaceInfo(string spaceName,string description,string spaceId,string spaceIconUrl)
        {
            this.spaceName = spaceName;
            this.spaceId = spaceId;
            this.description = description;
            this.spaceIconUrl = spaceIconUrl;
        }
        public string spaceName;
        public string description;
        public string spaceId;
        public string spaceIconUrl;
    }
}
