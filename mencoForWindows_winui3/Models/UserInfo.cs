using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;

namespace mencoForWindows_winui3.Models
{
    public class UserInfo
    {
        public UserInfo(string userId,string userName,string userFullName,string userToken,string userIconUrl)
        {
            this.userId = userId;
            this.userName = userName;
            this.userFullName = userFullName;
            this.userToken = userToken;
            this.userIconUrl = userIconUrl;
        }
        public string userId;
        public string userName;
        public string userFullName;
        public string userToken;
        public string userIconUrl;
    }
}
