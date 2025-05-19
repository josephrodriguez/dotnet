using System.Diagnostics.CodeAnalysis;
using Dotnet.Performance.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using WebApi.Performance.Infrastructure;

namespace Dotnet.Performance.WebApi.Extensions;

internal static class EndpointRouteBuilderExtensions
{
    [RequiresDynamicCode("Calls Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.MapGet(String, Delegate)")]
    [UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
    public static IEndpointRouteBuilder MapPerformanceEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var performanceApi = endpoints.MapGroup("/api/performance");

        performanceApi.MapGet("/movies", async (IMoviesRepository repository, CancellationToken cancellationToken) => await GetMoviesHandlerAsync(repository, cancellationToken));
        
        return endpoints;
    }
    
    [RequiresDynamicCode("Calls Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.MapGet(String, Delegate)")]
    [UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
    public static IEndpointRouteBuilder MapHealthEndpoint(this IEndpointRouteBuilder endpoints)
    {
        var healthGroup = endpoints.MapGroup("/api");

        healthGroup.MapGet("/health", () => Results.Ok("API is healthy"));
        
        return endpoints;
    }

    private static async Task<IResult> GetMoviesHandlerAsync([FromServices] IMoviesRepository repository, CancellationToken cancellationToken)
    {
        var movies = await repository.GetMoviesAsync(cancellationToken);
        return movies is not null ? Results.Ok(movies) : Results.NotFound();
    }
}