using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using mencoForWindows_winui3.DataModels.UserData;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
	public class SpacePostAttachmentsItemDataModel
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("categories")]
		public List<string> Categories { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("resourceId")]
		public string ResourceId { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("uri")]
		public string Uri { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("via")]
		public string Via { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("mime")]
		public string Mime { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("author")]
		public UserDataModel Author { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("likedCount")]
		public int LikedCount { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("_id")]
		public string Id { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("seenCount")]
		public int SeenCount { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("identifier")]
		public string Identifier { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("perspective")]
		public SpacePostAttachmentsItemPerspectiveDataModel Perspective { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("link")]
		public Dictionary<string,string> Link { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("container")]
		public string Container { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("size")]
		public int Size { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("createdAt")]
		public long CreatedAt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get;set; }
	}
}