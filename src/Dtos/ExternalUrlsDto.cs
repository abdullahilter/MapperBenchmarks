using System.Text.Json.Serialization;

namespace MapperBenchmarks.Dtos;

public sealed class ExternalUrlsDto
{
    [JsonPropertyName("spotify")]
    public string? Spotify { get; set; }
}