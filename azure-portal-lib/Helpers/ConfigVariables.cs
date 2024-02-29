namespace azure_portal_lib.Helpers
{
    public class ConfigVariables
    {
        public string BaseUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string SubscriptionId { get; set; }
        public string TenantId { get; set; }
        public string ResourceGroup { get; set; }

        public ConfigVariables(string baseUrl, string clientId, string clientSecret, string subscriptionId, string tenantId, string resourceGroup)
        {
            BaseUrl = baseUrl;
            ClientId = clientId;
            ClientSecret = clientSecret;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
            ResourceGroup = resourceGroup;
        }
    }

    public static class ConstantVariables
    {
        public static string BASE_AUTH_URL = "https://login.microsoftonline.com/";
        public static string BASE_AUTH_RESOURCE = "/oauth2/token";
        public static string RESOURCE_AUTH = "https://management.azure.com/";

        public static string CommonUrl(string subscriptionId, string resourceGroup,
            string provider)
        {
            return $"subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/{provider}";
        }
    }
}
