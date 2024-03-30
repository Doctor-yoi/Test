using System;
using System.ComponentModel;

using mencoForWindows_winui3.Cache;
using mencoForWindows_winui3.Helpers;
using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.Pages;

namespace mencoForWindows_winui3.ViewModels
{
    [Description("Finished")]
    public class SettingPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _Logout_Description;
        public string Logout_Description
        {
            get => _Logout_Description;
            set
            {
                if (_Logout_Description != value)
                {
                    _Logout_Description = value;
                    OnPropertyChanged();
                }
            }
        }

        public SettingPageViewModel()
        {
            Logout_Description = $"{GlobalData.userInfo.userFullName}" + (String.IsNullOrWhiteSpace(GlobalData.userInfo.userName) ? "" : $"({GlobalData.userInfo.userName})");
        }

        public void Logout()
        {
            GlobalData.userInfo = null;
            AppSetting.SetValue<bool>(SettingKeys.StoreUserLoginInfo, false);
            AppSetting.SetValue<string>(SettingKeys.UserLoginId, null);
            AppSetting.SetValue<string>(SettingKeys.UserPassword, null);
            ImageCache.Clear();
            this.Logout_Description = null;
            NavigateHelper.Navigate(typeof(LoginPage), "App");
            return;
        }

        public void OnPropertyChanged(string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
