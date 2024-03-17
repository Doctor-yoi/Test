using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

using MencoForWindows.User;

namespace MencoForWindows
{
    public class Global
    {
        public static readonly Dictionary<string, string> DEFAULT_HEADERS = new Dictionary<string, string>
        {
            { "X-MENCO-DEVICE","WebApi" },
            { "X-MENCO-VERSION","MobileSite" }
        };
        public static readonly string USERAGENT = "Mozilla/5.0 (iPhone; CPU iPhone OS 17_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.0 Mobile/15E148 Safari/604.1";
        public static class mencoApi
        {
            public static readonly string rootDomain = "http://menco.cn";
            public static readonly string userLogin = "http://menco.cn/api/account/login";
            public static readonly string userInfo = "http://menco.cn/api/account/feed/spaces";
            public static readonly string spaceRoot = "http://menco.cn/api/spaces";
            public static readonly string assetRootDomain = rootDomain;
        }
        public static UserInfo userInfo;
    }
}
