﻿namespace MapperBenchmarks.Entities;

public sealed class Item
{
    public Artist[]? Artists { get; set; }
    public string[]? AvailableMarkets { get; set; }
    public long DiscNumber { get; set; }
    public long DurationMs { get; set; }
    public bool Explicit { get; set; }
    public ExternalUrls? ExternalUrls { get; set; }
    public string? Href { get; set; }
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? PreviewUrl { get; set; }
    public long TrackNumber { get; set; }
    public string? Type { get; set; }
    public string? Uri { get; set; }
}