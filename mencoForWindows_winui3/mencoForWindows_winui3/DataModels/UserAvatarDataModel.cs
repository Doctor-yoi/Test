using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mencoForWindows_winui3.DataModels;

public class UserAvatarDataModel
{
    private string _small;
    [JsonPropertyName("small")]
    public string small
    {
        get => _small;
        set
        {
            _small = "http://menco.cn" + value.Replace("\\", "");
        }
    }

    private string _regular;
    [JsonPropertyName("regular")]
    public string regular
    {
        get => _regular;
        set
        {
            _regular = "http://menco.cn" + value.Replace("\\", "");
        }
    }
}
