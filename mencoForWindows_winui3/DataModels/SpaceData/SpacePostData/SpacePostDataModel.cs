using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
	[Obsolete("Please use MencoSearchResultWrapper<SpacePostResultDataModel> instead.")]
	public class SpacePostDataModel
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("results")]
		public List<SpacePostResultDataModel> Results { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("total")]
		public int Total { get;set; }
	}
}