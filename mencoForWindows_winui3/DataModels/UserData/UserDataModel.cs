using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mencoForWindows_winui3.DataModels.UserData;
/// <summary>
/// 
/// </summary>
public class UserDataModel
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("defaltSchool"), AllowNull]
    public string DefaultSchool { get; set; }

    private string _LastActivity;
    [JsonPropertyName("lastActivity")]
    public string LastActivity
    {
        get => _LastActivity;
        set => _LastActivity = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddSeconds(long.Parse(value)).ToString();
    }

    private string _UserCenterLink;
    [JsonPropertyName("link")]
    public string UserCenterLink
    {
        get => _UserCenterLink;
        set => _UserCenterLink = value.Replace("\\", "");
    }

    [JsonPropertyName("_id")]
    public string UserId { get; set; }

    [JsonPropertyName("accountType")]
    public string AccountType { get; set; }

    [JsonPropertyName("avatar")]
    public UserAvatarDataModel Avatar { get; set; }

    [JsonPropertyName("token")]
    public string Token { get; set; }

    private string _LastLogged;
    [JsonPropertyName("lastLogged")]
    public string LastLogged
    {
        get => _LastLogged;
        set => _LastLogged = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddSeconds(long.Parse(value)).ToString();
    }

    [JsonPropertyName("username")]
    public string UserName { get; set; }

    [JsonPropertyName("fullname")]
    public string FullName { get; set; }

    private string _CreatedAt;
    [JsonPropertyName("createdAt")]
    public string CreatedAt
    {
        get => _CreatedAt;
        set => _CreatedAt = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddSeconds(long.Parse(value)).ToString();
    }

    [JsonPropertyName("accessibility")]
    public UserAccessibilityDataModel Accessibility { get; set; }
}
