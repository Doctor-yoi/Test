using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MencoForWindows.Utils
{
    public class ExceptionHandler
    {
        public static void handleWebExceprion(HttpStatusCode errorCode,[AllowNull] string dataContainerName,ref Dictionary<string,object> dataContainer,WebException ex)
        {
            WebException we = (WebException)ex;
            if (we.Response != null)
            {
                using HttpWebResponse hr = (HttpWebResponse)we.Response;
                if (hr.StatusCode == HttpStatusCode.Conflict)
                {
                    dataContainer["statusCode"] = hr.StatusCode.ToString();
                    dataContainer["exMessage"] = new StreamReader(hr.GetResponseStream()).ReadToEnd();
                    if (dataContainerName != null)
                    {
                        dataContainer[dataContainerName] = null;
                    }
                }
            }
            else
            {
                dataContainer["statusCode"] = "E0";
                dataContainer["exMessage"] = "Cannot connect to the Internet.";
                if (dataContainerName != null)
                {
                    dataContainer[dataContainerName] = null;
                }
            }
        }
    }
}
