using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData
{
	public class SpaceAccessibilityPostDataModel
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("types")]
		public List<string> Types { get;set; }
	}
}