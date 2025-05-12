using WebApi.Performance.Core;

namespace WebApi.Performance.Infrastructure;

public interface IMoviesRepository
{
    Task<IEnumerable<Movie>?> GetMoviesAsync(CancellationToken cancellationToken = default);
}