using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData
{
	public class SpaceLinkDataModel
	{
		private string _Naiku;
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("naiku")]
		public string Naiku
		{
			get => _Naiku;
			set => _Naiku = "http://menco.cn" + value.Replace("\\", "");
        }

		private string _NaikuQuickQuestion;
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("naikuQuickQuestion")]
		public string NaikuQuickQuestion
		{
			get => _NaikuQuickQuestion;
			set => _NaikuQuickQuestion = "http://menco.cn" + value.Replace("\\", "");
        }

		private string _Page;
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("page")]
		public string Page
		{
			get => _Page;
			set => _Page = "http://menco.cn" + value.Replace("\\", "");
        }
	}
}