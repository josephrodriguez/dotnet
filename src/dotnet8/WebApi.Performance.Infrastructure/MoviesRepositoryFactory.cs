using WebApi.Performance.Infrastructure.Impl;

namespace WebApi.Performance.Infrastructure;

public static class MoviesRepositoryFactory
{
    public static IMoviesRepository FromJsonFile(string filePath)
    {
        return new FileJsonMoviesRepository(filePath);
    }
}