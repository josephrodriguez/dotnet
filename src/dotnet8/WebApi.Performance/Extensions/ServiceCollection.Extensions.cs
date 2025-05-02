using WebApi.Performance.Configuration;
using WebApi.Performance.Services;
using WebApi.Performance.Services.Impl;

namespace WebApi.Performance.Extensions;

internal static class ServiceCollection
{
    internal static IServiceCollection AddJsonFileMoviesRepository(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IMoviesRepository, FileJsonMoviesRepository>();
        services.AddOptions<FileProviderConfiguration>().Bind(configuration.GetSection("Provider"));

        return services;
    }
}