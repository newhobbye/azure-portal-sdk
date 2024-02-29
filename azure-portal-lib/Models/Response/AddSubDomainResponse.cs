using System.Text.Json.Serialization;

namespace azure_portal_lib.Models.Response
{
    public class AddSubDomainResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("properties")]
        public Property Properties { get; set; }
    }
}
