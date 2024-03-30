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

        public string spaceId;
        public string spaceName;
        public string spaceDescription;
        public string spaceIconUrl;
    }
}
