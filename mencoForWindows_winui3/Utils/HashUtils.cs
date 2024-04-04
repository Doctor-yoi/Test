using System.IO.Hashing;
using System.Text;

namespace mencoForWindows_winui3.Utils
{
    public static class HashUtils
    {
        public static string bytesToCRC32(byte[] input)
        {
            return Encoding.ASCII.GetString(Crc32.Hash(input));
        }
        public static string stringToCRC32(string input)
        {
            return Encoding.ASCII.GetString(Crc32.Hash(Encoding.UTF8.GetBytes(input)));
        }
    }
}
