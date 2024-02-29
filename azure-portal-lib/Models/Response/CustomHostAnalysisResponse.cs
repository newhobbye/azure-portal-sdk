using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace azure_portal_lib.Models.Response
{
    public class CustomHostAnalysisResponse
    {
        [JsonPropertyName("@xmlns:i")]
        public string XmlnsI { get; set; }

        [JsonPropertyName("@xmlns")]
        public string Xmlns { get; set; }
        //colocar aqui

        [JsonPropertyName("ARecords")]
        public ARecords ARecords { get; set; }

        [JsonPropertyName("CNameRecords")]
        public CNameRecords CNameRecords { get; set; }

        [JsonPropertyName("CustomDomainVerificationTest")]
        public string CustomDomainVerificationTest { get; set; }

        [JsonPropertyName("DomainLevel")]
        public string DomainLevel { get; set; }

        [JsonPropertyName("HasConflictAcrossSubscription")]
        public string HasConflictAcrossSubscription { get; set; }

        [JsonPropertyName("HasConflictOnScaleUnit")]
        public string HasConflictOnScaleUnit { get; set; }

        [JsonPropertyName("IsHostnameAlreadyVerified")]
        public string IsHostnameAlreadyVerified { get; set; }

        [JsonPropertyName("Tld")]
        public string Tld { get; set; }


        #region[error]
        [JsonPropertyName("CustomDomainVerificationFailureInfo")]
        public CustomDomainVerificationFailureInfo CustomDomainVerificationFailureInfo { get; set; }

        #endregion
    }
}
