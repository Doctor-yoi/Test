using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.UserData;

public class UserAccessibilityDataModel
{
    [JsonPropertyName("moderatable")]
    public bool Moderatable { get; set; }

    [JsonPropertyName("bubblesheetGuideVisible")]
    public bool BubblesheetGuideVisible { get; set; }

    [JsonPropertyName("dashboardGuideVisible")]
    public bool DashboardGuideVisible { get; set; }

    [JsonPropertyName("classroomGuideVisible")]
    public bool ClassroomGuideVisible { get; set; }
}
