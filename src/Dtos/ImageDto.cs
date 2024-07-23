using System.Text.Json.Serialization;

namespace MapperBenchmarks.Dtos;

public sealed class ImageDto
{
    [JsonPropertyName("height")]
    public long Height { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("width")]
    public long Width { get; set; }
}