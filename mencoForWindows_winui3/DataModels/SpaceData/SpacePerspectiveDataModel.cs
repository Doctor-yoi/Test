using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData
{
	public class SpacePerspectiveDataModel
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("owner")]
		public bool Owner { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("role")]
		public string Role { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("subscription")]
		public string Subscription { get;set; }
	}
}