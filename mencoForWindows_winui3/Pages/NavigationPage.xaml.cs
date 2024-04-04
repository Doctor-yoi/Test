using System.Linq;

using mencoForWindows_winui3.Helpers;

using Microsoft.UI.Xaml.Controls;

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
