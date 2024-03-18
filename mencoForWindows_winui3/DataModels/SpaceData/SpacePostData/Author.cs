using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
	public class Author
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("description")]
		public string Description { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("defaultSchool")]
		public string DefaultSchool { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("lastActivity")]
		public int LastActivity { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("link")]
		public string Link { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("_id")]
		public string Id { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("accountType")]
		public string AccountType { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("avatar")]
		public Avatar Avatar { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("lastLogged")]
		public int LastLogged { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("username")]
		public string Username { get;set; }

		/// <summary>
		/// 朱孝云
		/// </summary>
		[JsonPropertyName("fullname")]
		public string Fullname { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("createdAt")]
		public int CreatedAt { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("accessibility")]
		public SpacePostAccessibilityDataModel Accessibility { get;set; }
	}
}