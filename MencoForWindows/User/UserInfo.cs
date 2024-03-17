using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MencoForWindows.User
{
    public class UserInfo
    {
        public UserInfo(string token,string userName,string userId, List<SpaceInfo> enteredSpaceInfoList, string userIconUrl)
        {
            this.token = token;
            this.userName = userName;
            this.userId = userId;
            this.enteredSpaceInfoList = enteredSpaceInfoList;
            this.userIconUrl = userIconUrl;
        }
        public string token;
        public string userName;
        public string userId;
        public List<SpaceInfo> enteredSpaceInfoList;
        public string userIconUrl;
    }
}
