using System.Text.Json.Serialization;

namespace MapperBenchmarks.Dtos;

public sealed class ExternalIdsDto
{
    [JsonPropertyName("upc")]
    public string? Upc { get; set; }
}