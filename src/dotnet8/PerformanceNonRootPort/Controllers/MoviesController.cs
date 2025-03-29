using System.Net;
using Microsoft.AspNetCore.Mvc;
using PerformanceNonRootPort.Services;

namespace PerformanceNonRootPort.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController(IMoviesRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var movies = await repository.GetMoviesAsync();
            return Ok(movies);
        }
        catch (Exception e)
        {
            return StatusCode((int) HttpStatusCode.InternalServerError);
        }
    }
}