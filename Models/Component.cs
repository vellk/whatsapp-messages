using System.Text.Json.Serialization;
using WhatsAppTemplates.Models.Parameters;

namespace WhatsAppTemplates.Models;

public sealed class Component
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }
    
    [JsonPropertyName("parameters")]
    public List<Parameter> Parameters { get; init; } = [];
}