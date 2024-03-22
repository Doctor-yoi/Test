using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.Input;

using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.Service;
using mencoForWindows_winui3.Utils;

using Microsoft.UI.Xaml.Media.Imaging;

namespace mencoForWindows_winui3.ViewModels
{
    public partial class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private LoginService _loginService;

        private UserInfo _userInfo;
        public UserInfo userInfo
        {
            get => _userInfo;
            set
            {
                if (_userInfo != value)
                {
                    _userInfo = value;
                    OnPropertyChanged();
                }
            }
        }

        private BitmapImage _userIconImage;
        public BitmapImage userIconImage
        {
            get => _userIconImage;
            set
            {
                if (_userIconImage != value)
                {
                    _userIconImage = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainPageViewModel()
        {
            this._loginService = ServiceManager.GetService<LoginService>();
        }

        public void OnPropertyChanged(string name = "") => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        
        public async void Init()
        {
            this.userInfo = GlobalData.userInfo;

            var userIcon = await _loginService.GetUserIconAsync(userInfo.userIconUrl);
            this.userIconImage = ImageUtils.ByteArrayToBitmapImage(userIcon);
        }

        public async void testButton()
        {
            
        }
    }
}
