using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.UserData;

public class UserAvatarDataModel
{
    private string _Small;
    [JsonPropertyName("small")]
    public string Small
    {
        get => _Small;
        set => _Small = "http://menco.cn" + value.Replace("\\", "");
    }

    private string _Regular;
    [JsonPropertyName("regular")]
    public string Regular
    {
        get => _Regular;
        set => _Regular = "http://menco.cn" + value.Replace("\\", "");
    }
}
