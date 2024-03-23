using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using mencoForWindows_winui3.Cache;
using mencoForWindows_winui3.Clients;
using mencoForWindows_winui3.Utils;

using Microsoft.UI.Xaml.Media.Imaging;

namespace mencoForWindows_winui3.Service
{
    public class ImageService
    {
        private MencoClient _mencoClient;

        public ImageService(MencoClient? mencoClient)
        {
            this._mencoClient = mencoClient;
        }

        private async Task<byte[]> GetBytesImageAsync(string url)
        {
            return await _mencoClient.GetBytesImageAsync(url);
        }

        public async Task<BitmapImage> GetImageAsync(string url)
        {
            if (ImageCache.ContainsKey(url))
            {
                return ImageCache.GetValue(ImageCache.GetHashKey(url));
            }
            byte[] bytesImage = await GetBytesImageAsync(url);
            BitmapImage result = ImageUtils.ByteArrayToBitmapImage(bytesImage);
            ImageCache.Add(url, result);
            return result;
        }
    }
}
