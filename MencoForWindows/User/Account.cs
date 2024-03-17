using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MencoForWindows.User
{
    public class Account
    {
        public UserInfo GetUserInfo(string username,string password)
        {
            Dictionary<string, string> userLoginInfo = getUserLoginInfo(username, password);
            switch (userLoginInfo["statusCode"])
            {
                case "E0":
                    break;
                case "E1":
                    break;
                case "409":
                    break;
                case "200":
                    break;
            }
        }
        [Description("测试通过")]
        private Dictionary<string,string> getUserLoginInfo(string username,string password)
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "statusCode","E1" },
                { "userId","" },
                { "userName","" },
                { "accessToken","" },
                { "userIconUrl","" },
                { "exMessage","" }
            };
            Dictionary<string, string> loginInfo = new Dictionary<string, string>
            {
                { "loginId",username },
                { "password",password }
            };
            byte[] byteLoginJson = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(loginInfo));

            WebClient w = new WebClient();
            //添加必要的headers
            foreach (var header in Global.DEFAULT_HEADERS)
            {
                w.Headers.Add(header.Key, header.Value);
            }
            w.Headers.Add(HttpRequestHeader.UserAgent, Global.USERAGENT);
            w.Headers.Add(HttpRequestHeader.ContentType, "application/json;charset=utf-8");
            w.Headers.Add(HttpRequestHeader.ContentLength, byteLoginJson.Length.ToString());
            //发送post请求
            try
            {
                byte[] rsp = w.UploadData(Global.mencoApi.userLogin, "POST", byteLoginJson);
                string rspStr = Encoding.UTF8.GetString(rsp);
                Dictionary<string, object> userInfoJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(rspStr);
                result["statusCode"] = "200";
                result["userId"] = (string)userInfoJson["_id"];
                result["userName"] = (string)userInfoJson["fullname"];
                result["accessToken"] = (string)userInfoJson["token"];
                Dictionary<string, string> userIconUrlJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(userInfoJson["avatar"].ToString());
                result["userIconUrl"] = Global.mencoApi.assetRootDomain+userIconUrlJson["regular"];
            }
            catch (Exception ex)
            {
                if(ex.GetType().Name == "WebException")
                {
                    WebException we = (WebException)ex;
                    if (we.Response != null)
                    {
                        using HttpWebResponse hr = (HttpWebResponse)we.Response;
                        if (hr.StatusCode == HttpStatusCode.Conflict)
                        {
                            result["statusCode"] = hr.StatusCode.ToString();
                            result["exMessage"] = new StreamReader(hr.GetResponseStream()).ReadToEnd();
                        }
                    }
                    else
                    {
                        result["statusCode"] = "E0";
                        result["exMessage"] = "Cannot connect to the Internet.";
                    }
                }
                else
                {
                    result["statusCode"] = "E1";
                    result["exMessage"] = ex.Message;
                }
            }
            return result;
        }
        [Description("测试通过")]
        private Dictionary<string, object> getEnteredSpacesIdList(string userToken,string userId)
        {
            Dictionary<string, object> result = new Dictionary<string, object>
            {
                { "statusCode","E1" },
                { "list",null },
                { "exMessage","" }
            };

            WebClient w = new WebClient();
            //添加必要的headers
            foreach (var item in Global.DEFAULT_HEADERS)
            {
                w.Headers.Add(item.Key, item.Value);
            }
            w.Headers.Add("X-MENCO-TOKEN", userToken);
            w.Headers.Add("X-MENCO-USER", userId);
            w.Headers.Add(HttpRequestHeader.UserAgent, Global.USERAGENT);
            //发送get请求
            try
            {
                byte[] rsp = w.DownloadData(Global.mencoApi.userInfo);
                Dictionary<string, object> rspJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(Encoding.UTF8.GetString(rsp));
                JArray resultList = (JArray)rspJson["results"];
                if (resultList.Count != 0)
                {
                    var list = new List<SpaceInfo>();
                    foreach(var r in resultList)
                    {
                        Dictionary<string, object> itemJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(r.ToString());
                        string spaceId = (string)itemJson["_id"];
                        string spaceName = (string)itemJson["name"];
                        string spaceDescription = (string)itemJson["description"];
                        Dictionary<string, string> spaceIconUrlList = JsonConvert.DeserializeObject<Dictionary<string, string>>(((JObject)itemJson["avatar"]).ToString());
                        string spaceIconUrl = Global.mencoApi.assetRootDomain + spaceIconUrlList["regular"];
                        SpaceInfo spaceInfo = new SpaceInfo(spaceName, spaceDescription, spaceId, spaceIconUrl);
                        list.Add(spaceInfo);
                    }
                    result["list"] = list;
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name == "WebException")
                {
                    WebException we = (WebException)ex;
                    if (we.Response != null)
                    {
                        using HttpWebResponse hr = (HttpWebResponse)we.Response;
                        if (hr.StatusCode == HttpStatusCode.InternalServerError)
                        {
                            result["statusCode"] = hr.StatusCode.ToString();
                            result["exMessage"] = new StreamReader(hr.GetResponseStream()).ReadToEnd();
                        }
                    }
                    else
                    {
                        result["statusCode"] = "E0";
                        result["exMessage"] = "Cannot connect to the Internet";
                    }
                }
                else
                {
                    result["statusCode"] = "E1";
                    result["exMessage"] = ex.Message;
                }
            }

            return result;
        }
    }
}
