using System;
using System.ComponentModel;

using mencoForWindows_winui3.Helpers;
using mencoForWindows_winui3.Models;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace mencoForWindows_winui3.Pages
{
    [Description("Finished")]
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
            AutoLogin.IsChecked = AppSetting.GetValue<bool>(SettingKeys.StoreUserLoginInfo);
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
#if DEBUG
            AppDebugSettingMenu.Visibility = Visibility.Visible;
#endif
            string loginId = AppSetting.GetValue<string>(SettingKeys.UserLoginId);
            string password = AppSetting.GetValue<string>(SettingKeys.UserPassword);
            if (loginId is not null && password is not null)
            {
                LoginProgress.Visibility = Visibility.Visible;
                if (await vm.login(loginId, password))
                {
                    NavigateHelper.Navigate(typeof(NavigationPage), "App");
                    return;
                }
                LoginProgress.Visibility = Visibility.Collapsed;
                LoginForm.Visibility = Visibility.Visible;
                return;
            }
            LoginForm.Visibility = Visibility.Visible;
            base.OnNavigatedTo(e);
        }

        private void ShowPasswordChanged(object sender, RoutedEventArgs e)
        {
            Password.PasswordRevealMode = (bool)ShowPassword.IsChecked ? PasswordRevealMode.Visible : PasswordRevealMode.Hidden;
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginForm.Visibility = Visibility.Collapsed;
            LoginProgress.Visibility = Visibility.Visible;
            string loginId = LoginId.Text;
            string password = Password.Password;
            if(await vm.login(loginId, password))
            {
                NavigateHelper.Navigate(typeof(NavigationPage), "App");
                return;
            }
            LoginForm.Visibility = Visibility.Visible;
            LoginProgress.Visibility = Visibility.Collapsed;
            GC.Collect();
        }

        private void validateLoginInfo(object sender, RoutedEventArgs e)
        {
            if (LoginId.Text.Length > 0 && Password.Password.Length > 0)
            {
                LoginButton.IsEnabled = true;
                return;
            }
            LoginButton.IsEnabled = false;
        }

        private void AutoLoginOnChange(object sender, RoutedEventArgs e)
        {
            AppSetting.SetValue<bool>(SettingKeys.StoreUserLoginInfo, (bool)AutoLogin.IsChecked);
        }
    }
}
