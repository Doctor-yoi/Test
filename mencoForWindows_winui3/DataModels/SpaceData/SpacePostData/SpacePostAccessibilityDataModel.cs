using System.Text.Json.Serialization;

namespace mencoForWindows_winui3.DataModels.SpaceData.SpacePostData
{
    public class SpacePostAccessibilityDataModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("privateMessage")]
        public bool PrivateMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("commentable")]
        public bool Commentable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("bookmarkable")]
        public bool Bookmarkable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("highlightable")]
        public bool Highlightable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("editable")]
        public bool Editable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("commentFormViewable")]
        public bool CommentFormViewable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deleteable")]
        public bool Deleteable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("bookmarkViewable")]
        public bool BookmarkViewable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pinable")]
        public bool Pinable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("spaceEnterable")]
        public bool SpaceEnterable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("shareViewable")]
        public bool ShareViewable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("likeViewable")]
        public bool LikeViewable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("shareable")]
        public bool Shareable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("likeable")]
        public bool Likeable { get; set; }
    }
}