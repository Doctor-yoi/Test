using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
	public class Avatar
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("small")]
		public string Small { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("regular")]
		public string Regular { get;set; }
	}
}