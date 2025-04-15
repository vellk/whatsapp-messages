using System.Text.Json.Serialization;

namespace WhatsAppTemplates.Models;

public sealed class Template
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("language")]
    public required Language Language { get; init; }

    [JsonPropertyName("components")]
    public List<Component> Components { get; init; } = [];
}