using System.ComponentModel;

using mencoForWindows_winui3.Service;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace mencoForWindows_winui3.Pages
{
    [Description("Finished")]
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingPage : Page
    {
        private ImageService _imageService;

        public SettingPage()
        {
            this.InitializeComponent();
        }

        private void Logout_Button_Clicked(object sendet, RoutedEventArgs args)
        {
            vm.Logout();
        }
    }
}
