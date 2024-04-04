using System.ComponentModel;

using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.Service;

using Microsoft.UI.Xaml.Media.Imaging;

namespace mencoForWindows_winui3.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private UserService _loginService;
        private ImageService _imageService;
        private PostService _test;

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
            this._loginService = ServiceManager.GetService<UserService>();
            this._imageService = ServiceManager.GetService<ImageService>();
            this._test = ServiceManager.GetService<PostService>();
        }

        public void OnPropertyChanged(string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


        public async void Init()
        {
            this.userInfo = GlobalData.userInfo;
            this.userIconImage = await _imageService.GetImageAsync(userInfo.userIconUrl);
            _ = await _test.GetPostContentsAsync(GlobalData.userInfo, new SpaceInfo("5f47c6ee1a8ae2d44f912c55", null, null, null), 0);
        }
    }
}
