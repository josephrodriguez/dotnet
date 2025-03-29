using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace WebApi.Performance.Extensions;

internal static class WebApplicationExtensions
{
    internal static void MapHealthz(this WebApplication app)
        => app.MapHealthChecks("/healthz", new HealthCheckOptions { AllowCachingResponses = false });
}