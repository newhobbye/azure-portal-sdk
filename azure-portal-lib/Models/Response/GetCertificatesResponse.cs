using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace azure_portal_lib.Models.Response
{
    public class GetCertificatesResponse
    {
        [JsonPropertyName("value")]
        public List<Value> Value { get; set; }

        [JsonPropertyName("nextLink")]
        public object NextLink { get; set; }

        [JsonPropertyName("id")]
        public object Id { get; set; }
    }
}
