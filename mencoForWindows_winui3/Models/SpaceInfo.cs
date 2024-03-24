namespace mencoForWindows_winui3.Models
{
    public class SpaceInfo
    {
        public SpaceInfo(string spaceId, string spaceName, string spaceDesciption, string spaceIconUrl)
        {
            this.spaceId = spaceId;
            this.spaceName = spaceName;
            this.spaceDescription = spaceDescription;
            this.spaceIconUrl = spaceIconUrl;
        }

        private string _spaceId;
        private string _spaceName;
        private string _spaceDescription;
        private string _spaceIconUrl;

        public string spaceId
        {
            get => _spaceId;
            set => _spaceId = value;
        }
        public string spaceName
        {
            get => _spaceName;
            set => _spaceName = value;
        }
        public string spaceDescription
        {
            get => _spaceDescription;
            set => _spaceDescription = value;
        }
        public string spaceIconUrl
        {
            get => _spaceIconUrl;
            set => _spaceIconUrl = value;
        }
    }
}
