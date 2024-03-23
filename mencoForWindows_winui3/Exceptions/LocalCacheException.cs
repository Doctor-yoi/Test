using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mencoForWindows_winui3.Exceptions
{
    public class LocalCacheException : Exception
    {
        public int errorCode { get; init; }

        public LocalCacheException(int errorCode,string exMessage) : base($"{exMessage} ({errorCode})")
        {
            this.errorCode = errorCode;
        }
    }
}
