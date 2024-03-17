using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData
{
	public class SpaceAccessibilityDataModel
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("memberShipQuitable")]
		public bool MemberShipQuitable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("post")]
		public SpaceAccessibilityPostDataModel Post { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("bubbleSheetQuizViewable")]
		public bool BubbleSheetQuizViewable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("membersViewable")]
		public bool MembersViewable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("microAssessmentEnabled")]
		public bool MicroAssessmentEnabled { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("moderatable")]
		public bool Moderatable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("bubbleSheetStudentEnabled")]
		public bool BubbleSheetStudentEnabled { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("bubbleSheetQuizEnabled")]
		public bool BubbleSheetQuizEnabled { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("courseViewable")]
		public bool CourseViewable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("joinable")]
		public bool Joinable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("courseEportfolioViewable")]
		public bool CourseEportfolioViewable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("notification")]
		public bool Notification { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("postFormViewable")]
		public bool PostFormViewable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("membersModeratable")]
		public bool MembersModeratable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("redeemable")]
		public bool Redeemable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("bubbleSheetStudentViewable")]
		public bool BubbleSheetStudentViewable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("bubbleSheetQuiz")]
		public SpaceAccessibilityBubbleSheetQuizDataModel BubbleSheetQuiz { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("privateMessage")]
		public bool PrivateMessage { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("settingsViewable")]
		public bool SettingsViewable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("naikuViewable")]
		public bool NaikuViewable { get;set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("withPortfolio")]
		public bool WithPortfolio { get;set; }
	}
}