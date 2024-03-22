using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;

using mencoForWindows_winui3.Helpers;
using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.Pages;
using mencoForWindows_winui3.ViewModels;

using Microsoft.UI.Windowing;
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

namespace mencoForWindows_winui3
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private SystemBackdrop backdropHelper;

#if DEBUG
        public MainWindow()
        {
            this.InitializeComponent();
            this.ExtendsContentIntoTitleBar = true;
            Title = "门口学习网";
            backdropHelper = new SystemBackdrop(this);
            backdropHelper.TrySetAcrylic();
            SetTitleBar(AppTitleBar);
            mainFrame.Navigate(typeof(MainPage));
        }
#endif
        public MainWindow(UserInfo userInfo)
        {
            this.InitializeComponent();
            this.ExtendsContentIntoTitleBar = true;
            this.Title = "门口学习网";
            SetTitleBar(AppTitleBar);

            this.backdropHelper = new SystemBackdrop(this);
            backdropHelper.TrySetAcrylic(true);

            mainFrame.Navigate(typeof(MainPage));
        }

        private void addNavigationMenuItem()
        {
            
        }

        private void NavigationView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {

        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                //TODO:设置页
                return;
            }
            var selectedItem = (NavigationViewItem)args.SelectedItem;
            switch (selectedItem.Tag)
            {
                case "MainPage":
                    mainFrame.Navigate(typeof(MainPage));
                    return;
                case "PostPage":
                    return;
                case "DiscussionPage":
                    return;
                case "PersonalNotesPage":
                    return;
            }

        }
        public void Navigate(Type pageType)
        {
            mainFrame.Navigate(pageType);
        }
    }
}
