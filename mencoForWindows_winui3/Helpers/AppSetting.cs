using System.ComponentModel;

using Windows.Storage;

namespace mencoForWindows_winui3.Helpers
{
    [Description("Finished")]
    public static class AppSetting
    {
        private static readonly ApplicationDataContainer _appDataContainer;

        static AppSetting()
        {
            _appDataContainer = ApplicationData.Current.LocalSettings;
        }

        [Description("only for test")]
        public static bool ContainsKey(string key)
        {
            return _appDataContainer.Values.ContainsKey(key);
        }

        public static void SetValue<T>(string key, T value)
        {
            try
            {
                _appDataContainer.Values[key] = value?.ToString();
            }
            catch { }
        }

        public static T? GetValue<T>(string key, T? defaultValue = default)
        {
            T? value;
            if (TryGetValue<T>(key, out value, defaultValue))
            {
                return (T?)value;
            }
            else
            {
                return defaultValue;
            }
        }

        public static bool TryGetValue<T>(string key, out T? result, T? defaultValue = default)
        {
            try
            {
                var value = _appDataContainer.Values[key];
                if (value is T)
                {
                    result = (T)value;
                    return true;
                }
                else if (value is string)
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter is null)
                    {
                        result = defaultValue;
                        return false;
                    }
                    else
                    {
                        result = (T?)converter.ConvertFromString((string)value);
                        return true;
                    }
                }
                result = defaultValue;
                return false;
            }
            catch
            {
                result = defaultValue;
                return false;
            }
        }
    }
}