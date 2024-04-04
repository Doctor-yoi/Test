using System.Collections.Generic;

using mencoForWindows_winui3.DataModels;
using mencoForWindows_winui3.DataModels.SpaceData;
using mencoForWindows_winui3.Models;
using mencoForWindows_winui3.Service;

namespace mencoForWindows_winui3.Converter
{
    public static class WrappedSpaceInfoDataModelToSpaceInfoListConverter
    {
        private static ImageService _imageService;

        static WrappedSpaceInfoDataModelToSpaceInfoListConverter()
        {
            _imageService = ServiceManager.GetService<ImageService>();
        }
        public static List<SpaceInfo> Convert(MencoSearchResultWrapper<SpaceInfoDataModel> wrappedSpaceInfo)
        {
            List<SpaceInfo> result = new List<SpaceInfo>();
            var searchResult = wrappedSpaceInfo.Results;
            foreach (var space in searchResult)
            {
                result.Add(new SpaceInfo(space.Id, space.Name, space.Description, space.Avatar.Regular));
            }
            return result;
        }
    }
}
