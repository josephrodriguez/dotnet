using Dotnet.Performance.Core.Models;

namespace Dotnet.Performance.Infrastructure;

public interface IMoviesRepository
{
    Task<IEnumerable<Movie>?> GetMoviesAsync(CancellationToken cancellationToken = default);
}