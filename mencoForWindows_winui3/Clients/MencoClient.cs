using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using mencoForWindows_winui3.DataModels;
using mencoForWindows_winui3.DataModels.SpaceData;
using mencoForWindows_winui3.DataModels.SpaceData.SpacePostData;
using mencoForWindows_winui3.DataModels.UserData;
using mencoForWindows_winui3.Exceptions;

namespace mencoForWindows_winui3.Clients;

/// <summary>
/// 门口网api请求类
/// </summary>
public class MencoClient
{
    #region Constant

    private const string UserAgent = "User-Agent";
    private const string UAContent = "Mozilla/5.0 (iPhone; CPU iPhone OS 17_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.0 Mobile/15E148 Safari/604.1";
    private const string Accept = "Accept";
    private const string Application_Json = "application/json";
    private const string x_menco_device = "X-MENCO-DEVICE";
    private const string x_menco_device_content = "WebApi";
    private const string x_menco_version = "X-MENCO-VERSION";
    private const string x_menco_version_content = "MobileSite";
    private const string x_menco_user = "X-MENCO-USER";
    private const string x_menco_token = "X-MENCO-TOKEN";

    #endregion

    private readonly HttpClient _httpClient;

    public MencoClient(HttpClient? httpClient = null)
    {
        _httpClient = httpClient ?? new(new HttpClientHandler { AutomaticDecompression = System.Net.DecompressionMethods.All });
    }

    private async Task<T> CommonSendAsync<T>(HttpRequestMessage request, CancellationToken? cancellationToken = null) where T : class
    {
        request.Headers.Add(Accept, Application_Json);
        request.Headers.Add(UserAgent, UAContent);
        request.Headers.Add(x_menco_device, x_menco_device_content);
        request.Headers.Add(x_menco_version, x_menco_version_content);
        var response = await _httpClient.SendAsync(request, cancellationToken ?? CancellationToken.None);
        switch (response.StatusCode)
        {
            case HttpStatusCode.OK:
                return await response.Content.ReadFromJsonAsync<T>();
            case HttpStatusCode.Conflict:
                Dictionary<string, object> ErspData = await response.Content.ReadFromJsonAsync<Dictionary<string, object>>();
                JsonArray errorMessageList = ErspData.ContainsKey("LoginId") ? (JsonArray)ErspData["LoginId"] : (JsonArray)ErspData["password"];
                throw new ApiException(409, errorMessageList[0].ToString());
            case HttpStatusCode.InternalServerError:
                Dictionary<string, string> eMessageData = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                throw new ApiException(500, eMessageData["error"]);
            default:
                throw new ApiException(int.Parse(response.StatusCode.ToString()), "出现未知错误！请联系开发者");
        }
    }

    private async Task CommonSendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        await CommonSendAsync<object>(request, cancellationToken ?? CancellationToken.None);
        return;
    }

    public async Task<UserDataModel> GetUserDataAsync([NotNull] string loginId, [NotNull] string password,
        CancellationToken? cancellationToken = null)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, "http://menco.cn/api/account/login");
        return await CommonSendAsync<UserDataModel>(request, cancellationToken);
    }

    public async Task<MencoSearchResultWrapper<SpaceInfoDataModel>> GetUserJoinedSpacesDataAsync([NotNull] string userId, [NotNull] string userToken,
        CancellationToken? cancellationToken = null)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "http://menco.cn/api/account/feed/spaces");
        request.Headers.Add(x_menco_user, userId);
        request.Headers.Add(x_menco_token, userToken);
        return await CommonSendAsync<MencoSearchResultWrapper<SpaceInfoDataModel>>(request, cancellationToken);
    }

    public async Task<MencoSearchResultWrapper<SpacePostResultDataModel>> GetSpacePostDataAsync([NotNull] string userId, [NotNull] string userToken,
        [NotNull] string spaceId, string? postType = "announcement", int? offset = 0,CancellationToken? cancellationToken = null)
    {
        string reqUrl = $"http://menco.cn/api/spaces/{spaceId}/posts?filter={postType}&offset={offset}";
        var request = new HttpRequestMessage(HttpMethod.Get, reqUrl);
        request.Headers.Add(x_menco_user, userId);
        request.Headers.Add(x_menco_token, userToken);
        return await CommonSendAsync<MencoSearchResultWrapper<SpacePostResultDataModel>>(request, cancellationToken);
    }

    
}
