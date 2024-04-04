using System.ComponentModel;

using mencoForWindows_winui3.Helpers;
using mencoForWindows_winui3.Pages;

using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace mencoForWindows_winui3
{
    [Description("Finished")]
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private SystemBackdrop backdropHelper;

        public MainWindow()
        {
            this.InitializeComponent();

            this.backdropHelper = new SystemBackdrop(this);
            backdropHelper.TrySetAcrylic(false);

            NotificationHelper.Initialize(NotificationBar);
            NavigateHelper.InitAppRootFrame(rootFrame);
            NavigateHelper.Navigate(typeof(LoginPage), "App");
        }
        public string GetAppTitleFromSystem()
        {
            return Windows.ApplicationModel.Package.Current.DisplayName;
        }
    }
}
