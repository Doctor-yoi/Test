using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData
{
    public class SpaceAccessibilityBubbleSheetQuizDataModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("numericScoringEnabled")]
        public bool NumericScoringEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("rubricCriteriaEnabled")]
        public bool RubricCriteriaEnabled { get; set; }
    }
}