using System;
using System.ComponentModel;
using System.Threading.Tasks;

using mencoForWindows_winui3.Exceptions;
using mencoForWindows_winui3.Helpers;
using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.Service;

namespace mencoForWindows_winui3.ViewModels
{
    [Description("Finished")]
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private UserService _userService;

        private bool _storeUserInfo;
        public bool storeUserInfo
        {
            get => _storeUserInfo;
            set
            {
                if (_storeUserInfo != value)
                {
                    _storeUserInfo = value;
                    OnPropertyChanged();
                }
            }
        }

        public LoginPageViewModel()
        {
            this._userService = ServiceManager.GetService<UserService>();
            this._storeUserInfo = AppSetting.GetValue<bool>(SettingKeys.StoreUserLoginInfo);
        }

        public async Task<bool> login(string loginId, string password)
        {
            AppSetting.TryGetValue<bool>(SettingKeys.StoreUserLoginInfo, out bool isAutoLogin);
            if (isAutoLogin)
            {
                AppSetting.SetValue<bool>(SettingKeys.StoreUserLoginInfo, storeUserInfo);
                AppSetting.SetValue<string>(SettingKeys.UserLoginId, loginId);
                AppSetting.SetValue<string>(SettingKeys.UserPassword, password);
            }
            await Task.Delay(1000);
            try
            {
                var userInfo = await _userService.GetUserInfoAsync(loginId, password);
                await Task.Delay(1500);
                GlobalData.userInfo = userInfo;
                await Task.Delay(500);
                NotificationHelper.Success("登录成功");
                return true;
            }
            catch(ApiException apiEx)
            {
                if (apiEx.returnStatusCode == 409)
                {
                    NotificationHelper.Error(apiEx.Message);
                    return false;
                }
                NotificationHelper.Error("服务器内部错误");
                return false;
            }
            
        }

        public void OnPropertyChanged(string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
