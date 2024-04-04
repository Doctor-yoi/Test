using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using mencoForWindows_winui3.DataModels.SpaceData;

namespace mencoForWindows_winui3.DataModels.UserData;

[Obsolete("Please use MencoSearchResultWrapper<SpaceInfoDataModel> instead.")]
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
