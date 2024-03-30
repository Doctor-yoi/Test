using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;

namespace mencoForWindows_winui3.Models
{
    public class PageIndex : ObservableObject
    {
        private int _currentIndex;
        public int currentIndex
        {
            get => _currentIndex;
            set
            {
                if(_currentIndex != value)
                {
                    _currentIndex = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
