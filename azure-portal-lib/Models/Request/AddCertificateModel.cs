using System.Text.Json.Serialization;

namespace azure_portal_lib.Models.Request
{
    public class AddCertificateModel
    {
        [JsonPropertyName("location")]
        public string Location { get; set; } 

        [JsonPropertyName("kind")]
        public string? Kind { get; set; }

        [JsonPropertyName("properties")]
        public PropertiesCertificates Properties { get; set; }
    }

    public class PropertiesCertificates
    {
        [JsonPropertyName("canonicalName")]
        public string CanonicalName { get; set; }

        [JsonPropertyName("domainValidationMethod")]
        public string DomainValidationMethod { get; set; }

        [JsonPropertyName("hostNames")]
        public string[] HostNames { get; set; }

        [JsonPropertyName("keyVaultId")]
        public string KeyVaultId { get; set; }

        [JsonPropertyName("keyVaultSecretName")]
        public string KeyVaultSecretName { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("pfxBlob")]
        public string PfxBlob { get; set; }

        [JsonPropertyName("serverFarmId")]
        public string ServerFarmId { get; set; }
    }
}
