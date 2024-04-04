using System.Diagnostics;
using System.Threading;

namespace mencoForWindows_winui3.Utils
{
    public class UrlUtil
    {
        public void openUrl(string url)
        {
            Thread thread = new Thread(() =>
            {
                Process.Start(new ProcessStartInfo(url));
            });
            thread.Start();
        }
    }
}
