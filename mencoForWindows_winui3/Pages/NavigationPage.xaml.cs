using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using mencoForWindows_winui3.Helpers;
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
    public sealed partial class NavigationPage : Page
    {
        private NavigationViewItem lastSelected;

        public NavigationPage()
        {
            this.InitializeComponent();
            NavigateHelper.InitNavigatorRootFrame(mainFrame);
            RootNavigator.SelectedItem = RootNavigator.MenuItems.OfType<NavigationViewItem>().First();
            lastSelected = (NavigationViewItem)RootNavigator.SelectedItem;
        }

        private void RootNavigator_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (mainFrame.CanGoBack)
            {
                mainFrame.GoBack();
            }
        }

        private void RootNavigator_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                NavigateHelper.Navigate(typeof(SettingPage), "Navigator");
                return;
            }
            switch (((NavigationViewItem)args.SelectedItem).Tag)
            {
                case "PostPage":
                    NavigateHelper.Navigate(typeof(PostPage), "Navigator");
                    break;
                case "DiscussionPage":
                    NavigateHelper.Navigate(typeof(PostPage), "Navigator");
                    break;
                case "PersonalNotesPage":
                    NavigateHelper.Navigate(typeof(PostPage), "Navigator");
                    break;
                case "SwitchSpace":
                    RootNavigator.SelectedItem = lastSelected;
                    return;
            }
            lastSelected = (NavigationViewItem)args.SelectedItem;
        }
    }
}
