using System.Text.Json.Serialization;

namespace WhatsAppTemplates.Models.Parameters;

public sealed class Currency : Parameter
{
    [JsonPropertyName("currency")]
    public required string Code { get; init; }
    
    [JsonPropertyName("amount")]
    public required decimal Amount { get; init; }
}