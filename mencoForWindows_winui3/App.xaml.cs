using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using mencoForWindows_winui3.Helpers;
using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.Service;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;

using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace mencoForWindows_winui3
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        private UserService _loginService;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
#if DEBUG
            AppSetting.SetValue<string>("loginId", null);
            AppSetting.SetValue<string>("password", null);
#endif
            _loginService = ServiceManager.GetService<UserService>();
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override async void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            AppSetting.TryGetValue("loginId", out string loginId, null);
            AppSetting.TryGetValue("password", out string password, null);
            if(loginId is null || password is null)
            {
                m_window = new LoginWindow();
                m_window.Activate();
                m_window.ExtendsContentIntoTitleBar = true;
                return;
            }
            var userInfo = await _loginService.GetUserInfoAsync(loginId, password);
            GlobalData.userInfo = userInfo;
            m_window = new MainWindow();
            m_window.Activate();
            m_window.ExtendsContentIntoTitleBar = true;
        }
        private Window m_window;
    }
}
