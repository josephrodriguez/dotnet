using WebApi.Performance.Models;

namespace WebApi.Performance.Services;

public interface IMoviesRepository
{
    Task<IEnumerable<Movie>?> GetMoviesAsync(CancellationToken cancellationToken = default);
}