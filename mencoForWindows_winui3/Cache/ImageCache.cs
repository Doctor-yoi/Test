using System.Collections.Generic;

using mencoForWindows_winui3.Utils;

using Microsoft.UI.Xaml.Media.Imaging;

namespace mencoForWindows_winui3.Cache
{
    public static class ImageCache
    {
        private static Dictionary<string, BitmapImage> _imageCacheDictionary;
        private static bool _iniatialized;

        static ImageCache()
        {
            if (!_iniatialized)
            {
                Init();
            }
        }

        private static void Init()
        {
            _imageCacheDictionary = new Dictionary<string, BitmapImage>();
            _iniatialized = true;
        }

        public static void Add(string originalKey, BitmapImage value)
        {
            if (!_iniatialized)
            {
                Init();
            }
            originalKey = HashUtils.stringToCRC32(originalKey);
            if (!_imageCacheDictionary.ContainsKey(originalKey))
            {
                _imageCacheDictionary.Add(originalKey, value);
                return;
            }
            _imageCacheDictionary[originalKey] = value;
        }

        public static BitmapImage GetValue(string hashKey)
        {
            if (!_iniatialized)
            {
                Init();
                return null;
            }
            if (_imageCacheDictionary.ContainsKey(hashKey))
            {
                return _imageCacheDictionary[hashKey];
            }
            return null;
        }

        public static string GetHashKey(string originalKey)
        {
            return HashUtils.stringToCRC32(originalKey);
        }

        public static bool ContainsKey(string originalKey)
        {
            return _imageCacheDictionary.ContainsKey(GetHashKey(originalKey));
        }

        public static void Clear()
        {
            _imageCacheDictionary = new Dictionary<string, BitmapImage>();
        }
    }
}
