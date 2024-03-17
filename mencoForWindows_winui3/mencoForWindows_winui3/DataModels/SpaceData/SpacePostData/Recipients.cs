using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
	public class Recipients
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("name")]
		public List<string> Name { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("directIds")]
		public List<string> DirectIds { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("cohortIds")]
		public List<string> CohortIds { get;set; }
	}
}