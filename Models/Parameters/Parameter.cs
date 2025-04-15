using System.Text.Json.Serialization;

namespace WhatsAppTemplates.Models.Parameters;

public abstract class Parameter
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}