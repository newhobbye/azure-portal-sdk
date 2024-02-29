using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace azure_portal_lib.Models.Response
{
    public class AuthModel
    {
        

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("expires_in")]
        public string ExpiresIn { get; set; }

        [JsonPropertyName("ext_expires_in")]
        public string ExtExpiresIn { get; set; }

        [JsonPropertyName("expires_on")]
        public string ExpiresOn { get; set; }

        [JsonPropertyName("not_before")]
        public string NotBefore { get; set; }

        [JsonPropertyName("resource")]
        public string Resource { get; set; }

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
        public DateTime GeneratedToken { get; set; }

        #region[ErrorAuth]

        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("error_description")]
        public string ErrorDescription { get; set; }

        [JsonPropertyName("error_codes")]
        public List<int> ErrorCodes { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        [JsonPropertyName("correlation_id")]
        public string CorrelationId { get; set; }

        [JsonPropertyName("error_uri")]
        public string ErrorUri { get; set; }

        #endregion
    }
}
