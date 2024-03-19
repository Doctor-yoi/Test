using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;

namespace mencoForWindows_winui3.Service
{
    internal static class ServiceManager
    {
        private static ServiceProvider _serviceProvider;

        private static bool _isInitialized;

        public static void Initialize()
        {
            if (!_isInitialized)
            {
                var sc = new ServiceCollection();
                //TODO: 增加service配置
                _serviceProvider = sc.BuildServiceProvider();
                _isInitialized = true;
            }
        }

        private static void ConfigureHttpClient(ServiceCollection sc)
        {
            sc.Configure<HttpClientFactoryOptions>(options => {
                options.HttpMessageHandlerBuilderActions.Add(builder => 
                    builder.PrimaryHandler = new HttpClientHandler{
                        AutomaticDecompression = System.Net.DecompressionMethods.All
                    });
            });
        }

        public static T? GetService<T>()
        {
            if (!_isInitialized)
            {
                Initialize();
            }
            return ActivatorUtilities.GetServiceOrCreateInstance<T>(_serviceProvider);
        }

        public static void Dispose()
        {
            _serviceProvider?.Dispose();
        }
    }
}
