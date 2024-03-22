using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using mencoForWindows_winui3.DataModels.UserData;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
	public class SpacePostResultDataModel
	{
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
		[JsonPropertyName("commentsCount")]
		public int CommentsCount { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("createdAt")]
		public long CreatedAt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("moderated")]
		public string Moderated { get;set; }

		/// <summary>
		/// 我的乐园
		/// </summary>
		[JsonPropertyName("spaceName")]
		public string SpaceName { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("highlighted")]
		public bool Highlighted { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("updatedAt")]
		public string UpdatedAt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("accessibility")]
		public SpacePostAccessibilityDataModel Accessibility { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("receiveEmail")]
		public bool ReceiveEmail { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("attachments")]
		public List<SpacePostAttachmentsItemDataModel> Attachments { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("resources")]
		public List<string> Resources { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("recipients")]
		public SpacePostResultRecipientsDataModel Recipients { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("perspective")]
		public SpacePostResultPerspectiveDataModel Perspective { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("spaceId")]
		public string SpaceId { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("featured")]
		public bool Featured { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("encodedContent")]
		public string EncodedContent { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("content")]
		public string Content { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("author")]
		public UserDataModel Author { get;set; }
	}
}