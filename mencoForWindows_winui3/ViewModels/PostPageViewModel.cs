using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if(_postContent != value)
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
                if(_pageSelectedIndex != value)
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
#if DEBUG
            PostContent test = new PostContent();
            
#endif
        }

        public async void Init()
        {
            var spaceInfoList = await _userService.GetUserJoindSpaceInfoAsync(GlobalData.userInfo);
            if (spaceInfoList.Count < 1)
            {
                spaceInfoCollection.Add(new SpaceInfo(null, "未加入教室", null, null));
                return;
            }
            foreach (var space in spaceInfoList)
            {
                spaceInfoCollection.Add(space);
            }
            postContent = await _postService.GetPostContentsAsync(GlobalData.userInfo, new SpaceInfo("5f47c6ee1a8ae2d44f912c55", null, null, null), 0);
        }

        public async void ChangePage(int index)
        {
            pageSelectedIndex = index + 1;

            postContent = new List<PostContent>();
            //获取新post内容
        }

        public async void LoadPostCardList()
        {
            int offset = pageSelectedIndex * 10;
            
        }

        public void OnPropertyChanged(string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
