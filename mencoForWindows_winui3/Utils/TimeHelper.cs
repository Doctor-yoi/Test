﻿using System;

namespace mencoForWindows_winui3.Utils
{
    public static class TimeHelper
    {
        public static string TimeStampToString(long timestamp)
        {
            return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddSeconds(timestamp).ToString();
        }
    }
}
