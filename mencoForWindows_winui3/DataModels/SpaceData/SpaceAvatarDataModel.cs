using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData
{
	public class SpaceAvatarDataModel
	{
		private string _Small;
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("small")]
		public string Small
		{
			get => _Small;
			set => _Small = "http://menco.cn" + value.Replace("\\", "");
        }

		private string _Regular;
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("regular")]
		public string Regular
		{
			get => _Regular;
			set => _Regular = "http://menco.cn" + value.Replace("\\", "");
        }
	}
}