using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
