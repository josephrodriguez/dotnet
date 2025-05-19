using System.Text.Json;
using Dotnet.Performance.Core.Models;

namespace Dotnet.Performance.Infrastructure.Impl;

internal class FileJsonMoviesRepository(string filePath) : IMoviesRepository
{
    public async Task<IEnumerable<Movie>?> GetMoviesAsync(CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(filePath);
        
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"The file {filePath} does not exist.");
        }
        
        var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        var result = await JsonSerializer.DeserializeAsync<IEnumerable<Movie>>(fileStream, cancellationToken: cancellationToken);

        return result;
    }
}