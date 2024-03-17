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

namespace mencoForWindows_winui3.ViewModels
{
    partial class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        public MainPageViewModel()
        {
            this._userInfo = new UserInfo("TestId","TestName","TestFullName","TestToken");
        }

        public void OnPropertyChanged(string name = "") => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        [RelayCommand]
        public async void Init()
        {
            this.userInfo = new UserInfo("TestId", "TestName", "TestFullName", "TestToken");
        }

        [MTAThread]
        public async void testButton()
        {
            await Task.Delay(2000);
            this.userInfo = new UserInfo("TestId1", "TestName1", "TestFullName1", "TestToken1");
        }
    }
}
