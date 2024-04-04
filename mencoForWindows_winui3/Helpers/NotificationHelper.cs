using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Timers;

using Microsoft.UI.Xaml.Controls;

namespace mencoForWindows_winui3.Helpers
{
    [Description("Finished")]
    public static class NotificationHelper
    {
        private static Timer _cleanTimer;

        private static StackPanel _container;

        public static void Initialize(StackPanel container, int cleanDelay = 50000)
        {
            _container = container;
            _cleanTimer = new(cleanDelay);
            _cleanTimer.AutoReset = true;
            _cleanTimer.Elapsed += _time_elapsed;
            _cleanTimer.Start();
        }

        private static void _time_elapsed(object? sender, ElapsedEventArgs args)
        {
            if (_container is null)
            {
                return;
            }
            _container.DispatcherQueue?.TryEnqueue(() =>
            {
                var childen = _container.Children;
                foreach (var item in childen)
                {
                    if (item.ActualSize.X * item.ActualSize.Y == 0)
                    {
                        childen.Remove(item);
                    }
                }
            });
        }
        private static void AddInfoBarToContainer(InfoBarSeverity severity, string? title, string? message, int delay)
        {
            if (_container is null)
            {
                return;
            }
            _container.DispatcherQueue?.TryEnqueue(async () =>
            {
                var infoBar = new InfoBar
                {
                    Severity = severity,
                    Title = title,
                    Message = message,
                    IsOpen = true,
                };
                _container.Children.Add(infoBar);
                if (delay > 0)
                {

                    await Task.Delay(delay);
                    infoBar.IsOpen = false;
                }
            });
        }



        public static void Information(string message, int delay = 3000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Informational, null, message, delay);
        }


        public static void Information(string title, string message, int delay = 3000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Informational, title, message, delay);
        }


        public static void Success(string message, int delay = 3000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Success, null, message, delay);
        }


        public static void Success(string title, string message, int delay = 3000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Success, title, message, delay);
        }


        public static void Warning(string message, int delay = 5000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Warning, null, message, delay);
        }


        public static void Warning(string title, string message, int delay = 5000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Warning, title, message, delay);
        }


        public static void Error(string message, int delay = 5000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Error, null, message, delay);
        }


        public static void Error(string title, string message, int delay = 5000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Error, title, message, delay);
        }


        public static void Error(Exception ex, int delay = 5000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Error, ex.GetType().Name, ex.Message, delay);
        }


        public static void Error(Exception ex, string message, int delay = 5000)
        {
            AddInfoBarToContainer(InfoBarSeverity.Error, $"{ex.GetType().Name} - {message}", ex.Message, delay);
        }


        public static void Show(InfoBar infoBar, int delay = 0)
        {
            if (_container is null)
            {
                return;
            }
            _container.DispatcherQueue.TryEnqueue(async () =>
            {
                _container.Children.Add(infoBar);
                if (delay > 0)
                {
                    await Task.Delay(delay);
                    infoBar.IsOpen = false;
                }
            });
        }
    }
}
