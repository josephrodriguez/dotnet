using WebApi.Performance.Services;
using WebApi.Performance.Services.Impl;

namespace WebApi.Performance.Extensions;

internal static class ServiceCollectionExtensions
{
    internal static IServiceCollection AddJsonFileMoviesRepository(this IServiceCollection services)
        => services.AddScoped<IMoviesRepository>(_ => new FileJsonMoviesRepository("/data/movies.json"));
}