using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using CommunityToolkit.Mvvm.ComponentModel;

using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.ViewModels;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace mencoForWindows_winui3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    [INotifyPropertyChanged]
    public sealed partial class MainPage : Page
    {
        
        private UserInfo _userInfo;

        public MainPage()
        {
            this.InitializeComponent();
            Loaded += (_, _) => vm.Init();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.testButton();
        }
    }
}
