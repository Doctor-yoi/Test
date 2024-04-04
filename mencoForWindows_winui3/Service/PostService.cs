using System.Collections.Generic;
using System.Threading.Tasks;

using mencoForWindows_winui3.Clients;
using mencoForWindows_winui3.Exceptions;
using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.Utils;

namespace mencoForWindows_winui3.Service
{
    public class PostService
    {
        private MencoClient _mencoClient;
        private ImageService _imageService;

        public PostService(MencoClient? mencoClient)
        {
            this._mencoClient = mencoClient;
            this._imageService = ServiceManager.GetService<ImageService>();
        }

        public async Task<List<PostContent>> GetPostContentsAsync(UserInfo userInfo, SpaceInfo currentSpace, int offset)
        {
            var searchResult = await _mencoClient.GetSpacePostDataAsync(userInfo.userId, userInfo.userToken,
                currentSpace.spaceId, "announcement",
                offset);
            if (searchResult.Results.Count < 1)
            {
                throw new ApiException(20001, "超出索引范围");
            }
            var result = new List<PostContent>();
            foreach (var post in searchResult.Results)
            {
                var postContent = new PostContent();
                postContent.authorName = post.Author.FullName;
                postContent.updateTime = TimeHelper.TimeStampToString(post.UpdatedAt);
                postContent.likedCount = post.LikedCount;
                postContent.commentCount = post.CommentsCount;
                postContent.authorIcon = await _imageService.GetImageAsync(post.Author.Avatar.Regular);
                postContent.content = post.Content;
                result.Add(postContent);
            }
            return result;
        }
    }
}
