using System.Text.Json.Serialization;

namespace azure_portal_lib.Models.Request
{
    public class AddSubDomainModel
    {
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }

        [JsonPropertyName("properties")]
        public Property? Properties { get; set; }
    }

    
}
