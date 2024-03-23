using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using mencoForWindows_winui3.Cache;
using mencoForWindows_winui3.Helpers;
using mencoForWindows_winui3.Service;

using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.Windows.AppLifecycle;

using WinRT;

namespace mencoForWindows_winui3.ViewModels
{
    public class SettingPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ImageService _imageService;

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
        private BitmapImage _Logout_HeaderIcon;
        public BitmapImage Logout_HeaderIcon
        {
            get => _Logout_HeaderIcon;
            set
            {
                if (_Logout_HeaderIcon != value)
                {
                    _Logout_HeaderIcon = value;
                    OnPropertyChanged();
                }
            }
        }

        public SettingPageViewModel()
        {
            this._imageService = ServiceManager.GetService<ImageService>();
        }

        public async void Init()
        {
            this.Logout_Description = $"{GlobalData.userInfo.userFullName}" + (String.IsNullOrWhiteSpace(GlobalData.userInfo.userName) ? "" : $"({GlobalData.userInfo.userName})");
            this.Logout_HeaderIcon = await _imageService.GetImageAsync(GlobalData.userInfo.userIconUrl);
        }

        public void Logout()
        {
            GlobalData.userInfo = null;
            AppSetting.SetValue<string>("loginId", null);
            AppSetting.SetValue<string>("password", null);
            ImageCache.Clear();
            this.Logout_Description = null;
            this.Logout_HeaderIcon = null;
            AppInstance.Restart(null);
            return;
        }

        public void OnPropertyChanged(string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
