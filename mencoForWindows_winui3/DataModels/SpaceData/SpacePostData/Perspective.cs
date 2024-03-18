using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
	public class Perspective
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("liked")]
		public bool Liked { get;set; }
	}
}