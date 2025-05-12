using System.Text.Json.Serialization;

namespace WebApi.Performance.Core;

public class Movie
{
    [JsonPropertyName("title")] public string Title { get; set; }
    [JsonPropertyName("director")] public string Director { get; set; }
    [JsonPropertyName("rating")] public double Rating { get; set; }
    [JsonPropertyName("rank")] public int Rank { get; set; }
    [JsonPropertyName("synopsis")] public string Synopsis { get; set; }
    [JsonPropertyName("genre")] public string Genre { get; set; }
    [JsonPropertyName("release_year")] public int ReleaseYear { get; set; }
    [JsonPropertyName("cast")] public string Cast { get; set; }
}