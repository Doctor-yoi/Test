using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using mencoForWindows_winui3.DataModels.UserData;
using mencoForWindows_winui3.Models;

namespace mencoForWindows_winui3.Converter
{
    public static class UserDataModelToUserInfoConverter
    {
        public static UserInfo Convert(UserDataModel userDataModel)
        {
            string userId = userDataModel.UserId;
            string userName = userDataModel.UserName;
            string userFullName = userDataModel.FullName;
            string userToken = userDataModel.Token;
            string userIconUrl = userDataModel.Avatar.Regular;
            return new UserInfo(userId, userName, userFullName, userToken, userIconUrl);
        }
    }
}
