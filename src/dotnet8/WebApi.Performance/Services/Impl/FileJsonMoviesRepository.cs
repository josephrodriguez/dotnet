using System.Text.Json;
using WebApi.Performance.Models;

namespace WebApi.Performance.Services.Impl;

internal class FileJsonMoviesRepository(string filePath) : IMoviesRepository
{
    private readonly string _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));

    public async Task<IEnumerable<Movie>?> GetMoviesAsync(CancellationToken cancellationToken = default)
    {
        if (!File.Exists(_filePath))
        {
            throw new FileNotFoundException($"The file {_filePath} does not exist.");
        }
        
        var fileStream = new FileStream(_filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        var result = await JsonSerializer.DeserializeAsync<IEnumerable<Movie>>(fileStream, cancellationToken: cancellationToken);

        return result;
    }
}