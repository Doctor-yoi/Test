using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mencoForWindows_winui3.DataModels;

public class UserAccessibilityDataModel
{
    [JsonPropertyName("moderatable")]
    public bool moderatable;

    [JsonPropertyName("bubblesheetGuideVisible")]
    public bool bubblesheetGuideVisible;

    [JsonPropertyName("dashboardGuideVisible")]
    public bool dashboardGuideVisible;

    [JsonPropertyName("classroomGuideVisible")]
    public bool classroomGuideVisible;
}
