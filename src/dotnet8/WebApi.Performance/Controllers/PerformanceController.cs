using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApi.Performance.Services;

namespace WebApi.Performance.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PerformanceController(IMoviesRepository repository, ILogger<PerformanceController> logger) : ControllerBase
{
    [HttpGet]
    [Route("movies")]
    public async Task<IActionResult> GetMovies(CancellationToken cancellationToken = default)
    {
        try
        {
            logger.LogInformation("Handling request for GET movies endpoint.");
            
            var movies = await repository.GetMoviesAsync(cancellationToken);
            
            return Ok(movies);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while fetching movies.");
            
            return Problem(title: ex.Message, statusCode: (int) HttpStatusCode.InternalServerError);
        }
    }
}