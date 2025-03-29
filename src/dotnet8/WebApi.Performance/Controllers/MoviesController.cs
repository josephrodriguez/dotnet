using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApi.Performance.Services;

namespace WebApi.Performance.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController(IMoviesRepository repository, ILogger<MoviesController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            logger.LogInformation("Handling request for GET movies endpoint.");
            
            var movies = await repository.GetMoviesAsync();
            
            return Ok(movies);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while fetching movies.");
            
            return StatusCode((int) HttpStatusCode.InternalServerError, "An error occurred while processing your request.");
        }
    }
}