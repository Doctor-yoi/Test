using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using mencoForWindows_winui3.DataModels.SpaceData;

namespace mencoForWindows_winui3.DataModels.UserData;

public class UserJoinedSpacesDataModel
{
    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("results")]
    public List<SpaceInfoDataModel> Results { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }
}
