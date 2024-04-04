using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using mencoForWindows_winui3.Exceptions;

using Windows.Storage;

namespace mencoForWindows_winui3.Cache
{
    [Obsolete("maybe?")]
    public static class LocalCache
    {
        private static readonly StorageFolder _LocalCacheFolder;

        static LocalCache()
        {
            _LocalCacheFolder = ApplicationData.Current.LocalFolder;
        }

        public static async Task<StorageFile> GetLocalFileByUriAsync(string uri)
        {
            Dictionary<string, string[]> serializedUri = SerializeFilePath(uri);
            if (serializedUri["FileName"].Length == 0)
            {
                throw new LocalCacheException(101, "程序内部错误！请联系开发者！");
            }
            StorageFolder lastFolder = _LocalCacheFolder;
            foreach (var folderName in serializedUri["Folders"])
            {
                lastFolder = await lastFolder.GetFolderAsync(folderName);
            }
            return await lastFolder.GetFileAsync(serializedUri["FileName"][0]);
        }

        public static async void SaveLocalFileByUriAsync(string uri, byte[] fileBytes)
        {
            Dictionary<string, string[]> serializedUri = SerializeFilePath(uri);
            if (serializedUri["FileName"].Length == 0)
            {
                throw new LocalCacheException(102, "非法路径！");
            }
            StorageFolder lastFolder = _LocalCacheFolder;
            foreach (var folder in serializedUri["Folders"])
            {
                lastFolder = await lastFolder.GetFolderAsync(folder);
            }
            StorageFile file = await lastFolder.CreateFileAsync(serializedUri["FileName"][0]);
            await FileIO.WriteBytesAsync(file, fileBytes);
        }

        private static Dictionary<string, string[]> SerializeFilePath(string uri)
        {
            Dictionary<string, string[]> result = new Dictionary<string, string[]>();
            string separator = uri.Contains("/") ? "/" : "\\";

            string[] parts = uri.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string[] lastPart = parts[parts.Length - 1].Split(".");
            if (lastPart.Length == 2 && (!lastPart.Contains(string.Empty) || !lastPart.Contains("")))
            {
                result.Add("Folders", parts[..^1]);
                result.Add("FileName", new string[] { parts[parts.Length - 1] });
                return result;
            }
            result.Add("Folders", parts);
            result.Add("FileName", new string[] { null });
            return result;
        }
    }
}
