using PerformanceNonRootPort.Models;

namespace PerformanceNonRootPort.Services;

public interface IMoviesRepository
{
    Task<IEnumerable<Movie>> GetMoviesAsync();
}