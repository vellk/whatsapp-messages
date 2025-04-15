using System.Text.Json.Serialization;

namespace WhatsAppTemplates.Models;

public sealed class WhatsAppMessage
{
    [JsonPropertyName("to")]
    public required string To { get; init; }
    
    [JsonPropertyName("template")]
    public required Template Template { get; init; }
}