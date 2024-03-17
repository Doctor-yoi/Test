using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;

namespace mencoForWindows_winui3.Models
{
    class Test : ObservableObject
    {
        private string _content;
        public string content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }
    }
}
