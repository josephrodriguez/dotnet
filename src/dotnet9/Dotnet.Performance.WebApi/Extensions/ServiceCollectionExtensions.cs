using Dotnet.Performance.Infrastructure;

namespace Dotnet.Performance.WebApi.Extensions;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddJsonServices(this IServiceCollection services)
    {
        return services.ConfigureHttpJsonOptions(options =>
        {
            options.SerializerOptions.TypeInfoResolverChain.Insert(0, Dotnet.Performance.WebApi.AppJsonSerializerContext.Default);
        });
    }

    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IMoviesRepository>(_ => MoviesRepositoryFactory.FromJsonFile("/data.json"));
        return services;
    }
}