using System.Net.Http;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using mencoForWindows_winui3.Clients;

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
                ConfigureHttpClient(sc);
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
            sc.AddHttpClient();
            sc.AddHttpClient<MencoClient>()
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler{ AutomaticDecompression = System.Net.DecompressionMethods.All });
            //TODO: new httpClient
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
