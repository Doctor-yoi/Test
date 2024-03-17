using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mencoForWindows_winui3.DataModels;
/// <summary>
/// Post /api/account/login
/// 返回数据结构
/// </summary>
public class UserDataModel
{
    [JsonPropertyName("description")]
    public string description;

    [JsonPropertyName("defaltSchool"), AllowNull]
    public string defaultSchool;

    private string _lastActivity;
    [JsonPropertyName("lastActivity")]
    public string lastActivity
    {
        get => _lastActivity;
        set
        {
            _lastActivity = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)).AddSeconds(long.Parse(value)).ToString();
        }
    }

    private string _userCenterLink;
    [JsonPropertyName("link")]
    public string userCenterLink
    {
        get => _userCenterLink;
        set => _userCenterLink = value.Replace("\\", "");
    }

    [JsonPropertyName("_id")]
    public string userId;

    [JsonPropertyName("accountType")]
    public string accountType;

    [JsonPropertyName("avatar")]
    public UserAvatarDataModel avatar;

    [JsonPropertyName("token")]
    public string token;

    private string _lastLogged;
    [JsonPropertyName("lastLogged")]
    public string lastLogged
    {
        get => _lastLogged;
        set
        {
            _lastLogged = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)).AddSeconds(long.Parse(value)).ToString();
        }
    }

    [JsonPropertyName("username")]
    public string userName;

    [JsonPropertyName("fullname")]
    public string fullName;

    private string _createdAt;
    [JsonPropertyName("createdAt")]
    public string createdAt
    {
        get => _createdAt;
        set
        {
            _createdAt = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)).AddSeconds(long.Parse(value)).ToString();
        }
    }

    [JsonPropertyName("accessibility")]
    public UserAccessibilityDataModel accessibility;
}
