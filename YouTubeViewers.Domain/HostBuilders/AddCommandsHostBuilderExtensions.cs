using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Domain.Commands;
using YouTubeViewers.Domain.Queries;
using YouTubeViewers.EntityFramework.Commands;
using YouTubeViewers.EntityFramework.Queries;

namespace YouTubeViewers.WPF.HostBuilders
{
    internal static class AddCommandsHostBuilderExtensions
    {
        public static IHostBuilder AddCommands(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context, services) =>
           {
               services.AddSingleton<IGetAllYouTubeViewersQuery, GetAllYouTubeViewersQuery>();
               services.AddSingleton<ICreateYouTubeViewerCommand, CreateYouTubeViewerCommand>();
               services.AddSingleton<IUpdateYouTubeViewerCommand, UpdateYouTubeViewerCommand>();
               services.AddSingleton<IDeleteYouTubeViewerCommand, DeleteYouTubeViewerCommand>();
           });

            return hostBuilder;
        }
    }
}
