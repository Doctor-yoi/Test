using System;

using mencoForWindows_winui3.Helpers;
using mencoForWindows_winui3.Pages;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

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
        public MainWindow()
        {
            this.InitializeComponent();
            this.ExtendsContentIntoTitleBar = true;
            this.Title = "ÃÅ¿ÚÑ§Ï°Íø";
            SetTitleBar(AppTitleBar);

            this.backdropHelper = new SystemBackdrop(this);
            backdropHelper.TrySetAcrylic(true);

            mainFrame.Navigate(typeof(MainPage));
        }

        private void NavigationView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (mainFrame.CanGoBack)
            {
                mainFrame.GoBack();
            }
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                mainFrame.Navigate(typeof(SettingPage));
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
    }
}
