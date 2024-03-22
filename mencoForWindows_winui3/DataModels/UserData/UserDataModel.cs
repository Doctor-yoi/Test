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

    [JsonPropertyName("lastActivity")]
    public long LastActivity { get; set; }

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

    [JsonPropertyName("lastLogged")]
    public long LastLogged { get; set; }

    [JsonPropertyName("username")]
    public string UserName { get; set; }

    [JsonPropertyName("fullname")]
    public string FullName { get; set; }

    [JsonPropertyName("createdAt")]
    public long CreatedAt { get; set; }

    [JsonPropertyName("accessibility")]
    public UserAccessibilityDataModel Accessibility { get; set; }
}
