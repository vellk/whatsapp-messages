using System.Text.Json.Serialization;

namespace WhatsAppTemplates.Models.Parameters;

public sealed class Media : Parameter
{
    [JsonPropertyName("url")]
    public required string Url { get; init; }
}