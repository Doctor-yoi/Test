using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.Service;

namespace mencoForWindows_winui3.ViewModels
{
    public class PostPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private UserService _userService;
        private ImageService _imageService;
        private PostService _postService;

        private ObservableCollection<SpaceInfo> _spaceInfoCollection;
        public ObservableCollection<SpaceInfo> spaceInfoCollection
        {
            get => _spaceInfoCollection;
            set
            {
                if (_spaceInfoCollection != value)
                {
                    _spaceInfoCollection = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _fontSize;
        public int fontSize
        {
            get => _fontSize;
            set
            {
                if (_fontSize != value)
                {
                    _fontSize = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<PostContent> _postContent;
        public List<PostContent> postContent
        {
            get => _postContent;
            set
            {
                if (_postContent != value)
                {
                    _postContent = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _pageSelectedIndex;
        public int pageSelectedIndex
        {
            get => _pageSelectedIndex;
            set
            {
                if (_pageSelectedIndex != value)
                {
                    _pageSelectedIndex = value;
                    OnPropertyChanged();
                }
            }
        }

        public PostPageViewModel()
        {
            this._userService = ServiceManager.GetService<UserService>();
            this._imageService = ServiceManager.GetService<ImageService>();
            this._postService = ServiceManager.GetService<PostService>();
            this._spaceInfoCollection = new ObservableCollection<SpaceInfo>();
            this._fontSize = 20;
            this._postContent = new List<PostContent>();
            this._pageSelectedIndex = 1;
        }

        public async void Init()
        {

        }

        public async void ChangePage(int index)
        {

        }

        public async void LoadPostCardList()
        {

        }

        public void OnPropertyChanged(string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
