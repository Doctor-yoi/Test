using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

using mencoForWindows_winui3.DataModels.UserData;

namespace mencoForWindows_winui3.DataModels.SpaceData
{
	public class SpaceInfoDataModel
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("sector")]
		public string Sector { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("language")]
		public string Language { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("link")]
		public SpaceLinkDataModel Link { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("spaceType")]
		public string SpaceType { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("schoolClassroom"), AllowNull]
		public string SchoolClassroom { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("_id")]
		public string Id { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("subject")]
		public string Subject { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("membersCount"), JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
		public int MembersCount { get;set; }

        private string _CreatedAt;
		/// <summary>
		/// 
		/// </summary>
        [JsonPropertyName("createdAt")]
        public string CreatedAt
        {
            get => _CreatedAt;
            set => _CreatedAt = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)).AddSeconds(long.Parse(value)).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("category")]
		public string Category { get;set; }

		/// <summary>
		/// 我的乐园
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("spaceDefaultSection"), AllowNull]
		public string SpaceDefaultSection { get;set; }

        private string _UpdatedAt;
		/// <summary>
		/// 
		/// </summary>
        [JsonPropertyName("updatedAt")]
        public string updatedAt
        {
            get => _UpdatedAt;
            set => _UpdatedAt = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)).AddSeconds(long.Parse(value)).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("accessibility")]
		public SpaceAccessibilityDataModel Accessibility { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("grade")]
		public string Grade { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("serviceType")]
		public string ServiceType { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("avatar")]
		public SpaceAvatarDataModel Avatar { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("perspective")]
		public SpacePerspectiveDataModel Perspective { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("author")]
		public UserDataModel Author { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("description")]
		public string Description { get;set; }
	}
}