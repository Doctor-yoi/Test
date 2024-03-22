using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.UI.Xaml.Media.Imaging;

using Windows.Storage.Streams;

namespace mencoForWindows_winui3.Utils
{
    public static class ImageUtils
    {
        public static BitmapImage ByteArrayToBitmapImage(byte[] array)
        {
            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream ms = new MemoryStream(array))
            {
                bitmapImage.SetSource(ms.AsRandomAccessStream());
            }
            return bitmapImage;
        }
    }
}
