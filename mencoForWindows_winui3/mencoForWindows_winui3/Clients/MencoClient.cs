using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mencoForWindows_winui3.Clients;

/// <summary>
/// 门口网api请求类
/// </summary>
public class MencoClient
{
    #region Constant

    private const string UserAgent = "User-Agent";
    private const string UAContent = "Mozilla/5.0 (iPhone; CPU iPhone OS 17_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.0 Mobile/15E148 Safari/604.1";
    private const string x_menco_device = "X-MENCO-DEVICE";
    private const string x_menco_device_content = "WebApi";
    private const string x_menco_version = "X-MENCO-VERSION";
    private const string x_menco_version_content = "MobileSite";
    private const string x_menco_user = "X-MENCO-USER";
    private const string x_menco_token = "X-MENCO-TOKEN";

    #endregion
}
