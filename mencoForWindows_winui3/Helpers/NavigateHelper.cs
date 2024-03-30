using System;
using System.ComponentModel;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace mencoForWindows_winui3.Helpers
{
    [Description("Finished")]
    public static class NavigateHelper
    {
        private static Frame AppRootFrame;
        private static Frame NavigatorRootFrame;

        public static void InitAppRootFrame(Frame frame)
        {
            AppRootFrame = frame;
        }

        public static void InitNavigatorRootFrame(Frame frame)
        {
            NavigatorRootFrame = frame;
        }

        public static void Navigate(Type page,string frameType)
        {
            switch (frameType)
            {
                case "App":
                    AppRootFrame?.Navigate(page, new DrillInNavigationTransitionInfo());
                    return;
                case "Navigator":
                    NavigatorRootFrame?.Navigate(page, new DrillInNavigationTransitionInfo());
                    return;
            }
        }
    }
}
