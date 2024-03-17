using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData
{
	public class UserJoinedSpacesDataModel
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("results")]
		public List<SpaceInfoDataModel> Results { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("total")]
		public int Total { get;set; }
	}
}