using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;

namespace mencoForWindows_winui3.Models
{
    public class UserInfo : ObservableObject
    {
        public UserInfo(string userId,string userName,string userFullName,string userToken,string userIconUrl)
        {
            this.userId = userId;
            this.userName = userName;
            this.userFullName = userFullName;
            this.userToken = userToken;
            this.userIconUrl = userIconUrl;
        }
        private string _userId;
        private string _userName;
        private string _userFullName;
        private string _userToken;
        private string _userIconUrl;

        public string userId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }
        public string userName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }
        public string userFullName
        {
            get => _userFullName;
            set => SetProperty(ref _userFullName, value);
        }
        public string userToken
        {
            get => _userToken;
            set => SetProperty(ref _userToken, value);
        }
        public string userIconUrl
        {
            get => _userIconUrl;
            set => SetProperty(ref _userIconUrl, value);
        }
    }
}
