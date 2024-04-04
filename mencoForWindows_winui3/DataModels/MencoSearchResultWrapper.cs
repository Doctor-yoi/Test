using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels;

public class MencoSearchResultWrapper<T> where T : class
{
    [JsonPropertyName("results")]
    public List<T> Results { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}