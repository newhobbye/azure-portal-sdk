using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace azure_portal_lib.Models
{
    public class BaseResponse<DynamicResponse>
    {
        public DynamicResponse Value { get; set; }
        public string HttpStatusCode { get; set; }
        public Error Error { get; set; }
    }

    public class Error
    {
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        [JsonPropertyName("Message")]
        public string Message { get; set; }

        [JsonPropertyName("Target")]
        public object Target { get; set; }

        [JsonPropertyName("Details")]
        public List<Detail> Details { get; set; }

        [JsonPropertyName("Innererror")]
        public object Innererror { get; set; }
    }

    public class Detail
    {
        [JsonPropertyName("Message")]
        public string Message { get; set; }

        [JsonPropertyName("Code")]
        public string Code { get; set; }

        [JsonPropertyName("ErrorEntity")]
        public ErrorEntity ErrorEntity { get; set; }
    }

    public class ErrorEntity
    {
        [JsonPropertyName("ExtendedCode")]
        public string ExtendedCode { get; set; }

        [JsonPropertyName("MessageTemplate")]
        public string MessageTemplate { get; set; }

        [JsonPropertyName("Parameters")]
        public List<string> Parameters { get; set; }

        [JsonPropertyName("Code")]
        public string Code { get; set; }

        [JsonPropertyName("Message")]
        public string Message { get; set; }
    }
}
