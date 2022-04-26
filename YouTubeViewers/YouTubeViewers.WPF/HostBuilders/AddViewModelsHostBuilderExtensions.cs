using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.HostBuilders
{
    internal static class AddViewModelsHostBuilderExtensions
    {
        public static IHostBuilder AddViewModels(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context, services) =>
            {
                services.AddSingleton<ModalNavigationStore>();
                services.AddSingleton<YouTubeViewersStore>();
                services.AddSingleton<SelectedYouTubeViewerStore>();
            });

            return hostBuilder;
        }
    }
}
