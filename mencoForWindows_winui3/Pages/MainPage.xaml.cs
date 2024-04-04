using mencoForWindows_winui3.Service;

using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace mencoForWindows_winui3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private UserService _loginService;

        public MainPage()
        {
            this._loginService = ServiceManager.GetService<UserService>();
            this.InitializeComponent();
            vm.Init();
        }
    }
}
