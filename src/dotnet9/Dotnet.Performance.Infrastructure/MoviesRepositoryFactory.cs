using Dotnet.Performance.Infrastructure.Impl;

namespace Dotnet.Performance.Infrastructure;

public static class MoviesRepositoryFactory
{
    public static IMoviesRepository FromJsonFile(string filePath)
    {
        return new FileJsonMoviesRepository(filePath);
    }
}