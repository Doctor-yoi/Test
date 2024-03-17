using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

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
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void LoginPage_CheckBox_IsShowPassword_Change(object sender, RoutedEventArgs e)
        {
            LoginPage_PasswordBox_Password.PasswordRevealMode = (bool)LoginPage_CheckBox_IsShowPassword.IsChecked ? PasswordRevealMode.Visible : PasswordRevealMode.Hidden;
        }

        private void LoginPage_Button_Login_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
