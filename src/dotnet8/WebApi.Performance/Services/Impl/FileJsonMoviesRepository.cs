using System.Text.Json;
using Microsoft.Extensions.Options;
using WebApi.Performance.Configuration;
using WebApi.Performance.Models;

namespace WebApi.Performance.Services.Impl;

internal class FileJsonMoviesRepository(IOptions<FileProviderConfiguration> options) : IMoviesRepository
{

    public async Task<IEnumerable<Movie>?> GetMoviesAsync(CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(options);
        
        var filePath = options.Value.Path;
        
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"The file {filePath} does not exist.");
        }
        
        var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        var result = await JsonSerializer.DeserializeAsync<IEnumerable<Movie>>(fileStream, cancellationToken: cancellationToken);

        return result;
    }
}