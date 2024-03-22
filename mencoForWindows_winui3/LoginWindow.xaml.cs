using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

using mencoForWindows_winui3.Exceptions;
using mencoForWindows_winui3.Helpers;
using mencoForWindows_winui3.Service;

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
    public sealed partial class LoginWindow : Window
    {
        private LoginService _loginService;

        public LoginWindow()
        {
            this.InitializeComponent();
            SetTitleBar(AppTitleBar);

            this._loginService = ServiceManager.GetService<LoginService>();
        }
        private void LoginWindow_CheckBox_IsShowPassword_Change(object sender, RoutedEventArgs e)
        {
            LoginWindow_PasswordBox_Password.PasswordRevealMode = (bool)LoginWindow_CheckBox_IsShowPassword.IsChecked ? PasswordRevealMode.Visible : PasswordRevealMode.Hidden;
        }

        private async void LoginWindow_Button_Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userInfo = await _loginService.GetUserInfoAsync(LoginWindow_TextBox_Account.Text, LoginWindow_PasswordBox_Password.Password);
                GlobalData.userInfo = userInfo;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Activate();
                this.Close();
            }
            catch(Exception ex)
            {
                if(ex is ApiException)
                {
                    ex = (ApiException)ex;
                    InfoBar errorInfo = new InfoBar();
                    errorInfo.Title = "错误";
                    errorInfo.Message = ex.Message;
                    errorInfo.Severity = InfoBarSeverity.Error;
                    errorInfo.IsOpen = true;
                    NotificationContainer.Children.Add(errorInfo);
                    await Task.Delay(5000);
                    NotificationContainer.Children.Remove(errorInfo);
                }
                else
                {
                    InfoBar errorInfo = new InfoBar();
                    errorInfo.Title = "错误";
                    errorInfo.Message = "程序出现未预料的错误！请联系开发者：yoimiya0621@naganohara.top";
                    errorInfo.Severity = InfoBarSeverity.Error;
                    errorInfo.IsOpen = true;
                    NotificationContainer.Children.Add(errorInfo);
                    NotificationContainer.Children.Remove(errorInfo);
                }
            }
        }
    }
}
