using System.Text.Json.Serialization;

namespace WhatsAppTemplates.Models.Parameters;

public sealed class ButtonParameter : Parameter
{
    [JsonPropertyName("sub_type")]
    public required string SubType { get; init; }
    
    [JsonPropertyName("parameters")]
    public List<Parameter> Parameters { get; init; } = [];
}