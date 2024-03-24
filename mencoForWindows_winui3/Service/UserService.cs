using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using mencoForWindows_winui3.Clients;
using mencoForWindows_winui3.Converter;
using mencoForWindows_winui3.Models;

namespace mencoForWindows_winui3.Service
{
    public class UserService
    {
        private MencoClient _mencoClient;

        public UserService(MencoClient? mencoClient)
        {
            this._mencoClient = mencoClient;
        }

        public async Task<UserInfo> GetUserInfoAsync(string userName, string password)
        {
            var userData = await _mencoClient.GetUserDataAsync(userName, password);
            return UserDataModelToUserInfoConverter.Convert(userData);
        }

        public async Task<List<SpaceInfo>> GetUserJoindSpaceInfoAsync(UserInfo userinfo)
        {
            var joinedSpace = await _mencoClient.GetUserJoinedSpacesDataAsync(userinfo.userId, userinfo.userToken);
            return WrappedSpaceInfoDataModelToSpaceInfoListConverter.Convert(joinedSpace);
        }

        public async Task<byte[]> GetUserIconAsync(string userIconUrl)
        {
            return await _mencoClient.GetBytesImageAsync(userIconUrl);
        }
    }
}
