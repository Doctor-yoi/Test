using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using mencoForWindows_winui3.Clients;
using mencoForWindows_winui3.Models;

namespace mencoForWindows_winui3.Service
{
    public class LoginService
    {
        private MencoClient _mencoClient;

        public LoginService(MencoClient? mencoClient)
        {
            this._mencoClient = mencoClient;
        }

        public async Task<UserInfo> GetUserInfoAsync(string userName, string password)
        {
            var userData = await _mencoClient.GetUserDataAsync(userName, password);
            return new UserInfo(userData.UserId, userData.UserName, userData.FullName, userData.Token, userData.Avatar.Regular);
        }

        public async Task<byte[]> GetUserIconAsync(string userIconUrl)
        {
            return await _mencoClient.GetUserIconAsync(userIconUrl);
        }
    }
}
