using System.Text.Json.Serialization;

namespace MapperBenchmarks.Dtos;

public sealed class CopyrightDto
{
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}