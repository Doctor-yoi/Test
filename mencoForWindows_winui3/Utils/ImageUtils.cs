using System.IO;

using Microsoft.UI.Xaml.Media.Imaging;

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
