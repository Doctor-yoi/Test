using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
	public class Link
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("thumbnailSmall")]
		public string ThumbnailSmall { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("original")]
		public string Original { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("view")]
		public string View { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("player")]
		public string Player { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("thumbnail")]
		public string Thumbnail { get;set; }
	}
}