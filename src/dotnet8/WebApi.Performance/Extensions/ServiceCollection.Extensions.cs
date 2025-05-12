using WebApi.Performance.Infrastructure;
using WebApi.Performance.Infrastructure.Configuration;

namespace WebApi.Performance.Extensions;

internal static class ServiceCollection
{
    internal static IServiceCollection AddJsonFileMoviesRepository(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IMoviesRepository>(_ => 
            MoviesRepositoryFactory.FromJsonFile(configuration.GetValue<string>("Provider:Path") ?? string.Empty));

        return services;
    }
}