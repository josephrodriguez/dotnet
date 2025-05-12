using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using WebApi.Performance.Infrastructure;

namespace WebApi.Performance.MinimalAPI.Extensions;

internal static class EndpointRouteBuilderExtensions
{
    [RequiresDynamicCode("Calls Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.MapGet(String, Delegate)")]
    [UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
    public static IEndpointRouteBuilder MapPerformanceApiEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var performanceApi = endpoints.MapGroup("/api/performance");

        performanceApi.MapGet("/movies", async (IMoviesRepository repository, CancellationToken cancellationToken) => await GetMoviesHandlerAsync(repository, cancellationToken));
        performanceApi.MapGet("/health", () => Results.Ok("API is healthy"));
        
        return endpoints;
    }

    private static async Task<IResult> GetMoviesHandlerAsync([FromServices] IMoviesRepository repository, CancellationToken cancellationToken)
    {
        var movies = await repository.GetMoviesAsync(cancellationToken);
        return movies is not null ? Results.Ok(movies) : Results.NotFound();
    }
}