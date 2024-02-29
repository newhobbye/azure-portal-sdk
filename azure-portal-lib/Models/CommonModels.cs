using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace azure_portal_lib.Models
{
    public class Property
    {
        [JsonPropertyName("azureResourceName")]
        public string? AzureResourceName { get; set; }

        [JsonPropertyName("azureResourceType")]
        public string? AzureResourceType { get; set; }

        [JsonPropertyName("customHostNameDnsRecordType")]
        public string? CustomHostNameDnsRecordType { get; set; }

        [JsonPropertyName("domainId")]
        public string? DomainId { get; set; }

        [JsonPropertyName("hostNameType")]
        public string? HostNameType { get; set; }

        [JsonPropertyName("siteName")]
        public string? SiteName { get; set; }

        [JsonPropertyName("sslState")]
        public string? SslState { get; set; }

        [JsonPropertyName("thumbprint")]
        public string? Thumbprint { get; set; }
    }

    public class DnsConfiguration
    {
    }

    public class HostNameSslState
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("sslState")]
        public string SslState { get; set; }

        [JsonPropertyName("ipBasedSslResult")]
        public object IpBasedSslResult { get; set; }

        [JsonPropertyName("virtualIP")]
        public object VirtualIP { get; set; }

        [JsonPropertyName("thumbprint")]
        public object Thumbprint { get; set; }

        [JsonPropertyName("certificateResourceId")]
        public object CertificateResourceId { get; set; }

        [JsonPropertyName("toUpdate")]
        public object ToUpdate { get; set; }

        [JsonPropertyName("toUpdateIpBasedSsl")]
        public object ToUpdateIpBasedSsl { get; set; }

        [JsonPropertyName("ipBasedSslState")]
        public string IpBasedSslState { get; set; }

        [JsonPropertyName("hostType")]
        public string HostType { get; set; }
    }

    public class FullProperties
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("hostNames")]
        public List<string> HostNames { get; set; }

        [JsonPropertyName("webSpace")]
        public string WebSpace { get; set; }

        [JsonPropertyName("selfLink")]
        public string SelfLink { get; set; }

        [JsonPropertyName("repositorySiteName")]
        public string RepositorySiteName { get; set; }

        [JsonPropertyName("owner")]
        public object Owner { get; set; }

        [JsonPropertyName("usageState")]
        public string UsageState { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("adminEnabled")]
        public bool AdminEnabled { get; set; }

        [JsonPropertyName("enabledHostNames")]
        public List<string> EnabledHostNames { get; set; }

        [JsonPropertyName("siteProperties")]
        public SiteProperties SiteProperties { get; set; }

        [JsonPropertyName("availabilityState")]
        public string AvailabilityState { get; set; }

        [JsonPropertyName("sslCertificates")]
        public object SslCertificates { get; set; }

        [JsonPropertyName("csrs")]
        public List<object> Csrs { get; set; }

        [JsonPropertyName("cers")]
        public object Cers { get; set; }

        [JsonPropertyName("siteMode")]
        public object SiteMode { get; set; }

        [JsonPropertyName("hostNameSslStates")]
        public List<HostNameSslState> HostNameSslStates { get; set; }

        [JsonPropertyName("computeMode")]
        public object ComputeMode { get; set; }

        [JsonPropertyName("serverFarm")]
        public object ServerFarm { get; set; }

        [JsonPropertyName("serverFarmId")]
        public string ServerFarmId { get; set; }

        [JsonPropertyName("reserved")]
        public bool Reserved { get; set; }

        [JsonPropertyName("isXenon")]
        public bool IsXenon { get; set; }

        [JsonPropertyName("hyperV")]
        public bool HyperV { get; set; }

        [JsonPropertyName("lastModifiedTimeUtc")]
        public DateTime LastModifiedTimeUtc { get; set; }

        [JsonPropertyName("storageRecoveryDefaultState")]
        public string StorageRecoveryDefaultState { get; set; }

        [JsonPropertyName("contentAvailabilityState")]
        public string ContentAvailabilityState { get; set; }

        [JsonPropertyName("runtimeAvailabilityState")]
        public string RuntimeAvailabilityState { get; set; }

        [JsonPropertyName("dnsConfiguration")]
        public DnsConfiguration DnsConfiguration { get; set; }

        [JsonPropertyName("vnetRouteAllEnabled")]
        public bool VnetRouteAllEnabled { get; set; }

        [JsonPropertyName("containerAllocationSubnet")]
        public object ContainerAllocationSubnet { get; set; }

        [JsonPropertyName("useContainerLocalhostBindings")]
        public object UseContainerLocalhostBindings { get; set; }

        [JsonPropertyName("vnetImagePullEnabled")]
        public bool VnetImagePullEnabled { get; set; }

        [JsonPropertyName("vnetContentShareEnabled")]
        public bool VnetContentShareEnabled { get; set; }

        [JsonPropertyName("siteConfig")]
        public SiteConfig SiteConfig { get; set; }

        [JsonPropertyName("deploymentId")]
        public string DeploymentId { get; set; }

        [JsonPropertyName("slotName")]
        public object SlotName { get; set; }

        [JsonPropertyName("trafficManagerHostNames")]
        public object TrafficManagerHostNames { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("scmSiteAlsoStopped")]
        public bool ScmSiteAlsoStopped { get; set; }

        [JsonPropertyName("targetSwapSlot")]
        public object TargetSwapSlot { get; set; }

        [JsonPropertyName("hostingEnvironment")]
        public object HostingEnvironment { get; set; }

        [JsonPropertyName("hostingEnvironmentProfile")]
        public object HostingEnvironmentProfile { get; set; }

        [JsonPropertyName("clientAffinityEnabled")]
        public bool ClientAffinityEnabled { get; set; }

        [JsonPropertyName("clientCertEnabled")]
        public bool ClientCertEnabled { get; set; }

        [JsonPropertyName("clientCertMode")]
        public string ClientCertMode { get; set; }

        [JsonPropertyName("clientCertExclusionPaths")]
        public object ClientCertExclusionPaths { get; set; }

        [JsonPropertyName("hostNamesDisabled")]
        public bool HostNamesDisabled { get; set; }

        [JsonPropertyName("vnetBackupRestoreEnabled")]
        public bool VnetBackupRestoreEnabled { get; set; }

        [JsonPropertyName("domainVerificationIdentifiers")]
        public object DomainVerificationIdentifiers { get; set; }

        [JsonPropertyName("customDomainVerificationId")]
        public string CustomDomainVerificationId { get; set; }

        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("managedEnvironmentId")]
        public object ManagedEnvironmentId { get; set; }

        [JsonPropertyName("inboundIpAddress")]
        public string InboundIpAddress { get; set; }

        [JsonPropertyName("possibleInboundIpAddresses")]
        public string PossibleInboundIpAddresses { get; set; }

        [JsonPropertyName("ftpUsername")]
        public string FtpUsername { get; set; }

        [JsonPropertyName("ftpsHostName")]
        public string FtpsHostName { get; set; }

        [JsonPropertyName("outboundIpAddresses")]
        public string OutboundIpAddresses { get; set; }

        [JsonPropertyName("possibleOutboundIpAddresses")]
        public string PossibleOutboundIpAddresses { get; set; }

        [JsonPropertyName("containerSize")]
        public int ContainerSize { get; set; }

        [JsonPropertyName("dailyMemoryTimeQuota")]
        public int DailyMemoryTimeQuota { get; set; }

        [JsonPropertyName("suspendedTill")]
        public object SuspendedTill { get; set; }

        [JsonPropertyName("siteDisabledReason")]
        public int SiteDisabledReason { get; set; }

        [JsonPropertyName("functionExecutionUnitsCache")]
        public object FunctionExecutionUnitsCache { get; set; }

        [JsonPropertyName("maxNumberOfWorkers")]
        public object MaxNumberOfWorkers { get; set; }

        [JsonPropertyName("homeStamp")]
        public string HomeStamp { get; set; }

        [JsonPropertyName("cloningInfo")]
        public object CloningInfo { get; set; }

        [JsonPropertyName("hostingEnvironmentId")]
        public object HostingEnvironmentId { get; set; }

        [JsonPropertyName("tags")]
        public Tags Tags { get; set; }

        [JsonPropertyName("resourceGroup")]
        public string ResourceGroup { get; set; }

        [JsonPropertyName("defaultHostName")]
        public string DefaultHostName { get; set; }

        [JsonPropertyName("slotSwapStatus")]
        public object SlotSwapStatus { get; set; }

        [JsonPropertyName("httpsOnly")]
        public bool HttpsOnly { get; set; }

        [JsonPropertyName("endToEndEncryptionEnabled")]
        public bool EndToEndEncryptionEnabled { get; set; }

        [JsonPropertyName("redundancyMode")]
        public string RedundancyMode { get; set; }

        [JsonPropertyName("inProgressOperationId")]
        public object InProgressOperationId { get; set; }

        [JsonPropertyName("geoDistributions")]
        public object GeoDistributions { get; set; }

        [JsonPropertyName("privateEndpointConnections")]
        public List<object> PrivateEndpointConnections { get; set; }

        [JsonPropertyName("publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        [JsonPropertyName("buildVersion")]
        public object BuildVersion { get; set; }

        [JsonPropertyName("targetBuildVersion")]
        public object TargetBuildVersion { get; set; }

        [JsonPropertyName("migrationState")]
        public object MigrationState { get; set; }

        [JsonPropertyName("eligibleLogCategories")]
        public string EligibleLogCategories { get; set; }

        [JsonPropertyName("inFlightFeatures")]
        public List<object> InFlightFeatures { get; set; }

        [JsonPropertyName("storageAccountRequired")]
        public bool StorageAccountRequired { get; set; }

        [JsonPropertyName("virtualNetworkSubnetId")]
        public object VirtualNetworkSubnetId { get; set; }

        [JsonPropertyName("keyVaultReferenceIdentity")]
        public string KeyVaultReferenceIdentity { get; set; }

        [JsonPropertyName("defaultHostNameScope")]
        public string DefaultHostNameScope { get; set; }

        [JsonPropertyName("privateLinkIdentifiers")]
        public object PrivateLinkIdentifiers { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class SiteConfig
    {
        [JsonPropertyName("numberOfWorkers")]
        public int NumberOfWorkers { get; set; }

        [JsonPropertyName("defaultDocuments")]
        public object DefaultDocuments { get; set; }

        [JsonPropertyName("netFrameworkVersion")]
        public object NetFrameworkVersion { get; set; }

        [JsonPropertyName("phpVersion")]
        public object PhpVersion { get; set; }

        [JsonPropertyName("pythonVersion")]
        public object PythonVersion { get; set; }

        [JsonPropertyName("nodeVersion")]
        public object NodeVersion { get; set; }

        [JsonPropertyName("powerShellVersion")]
        public object PowerShellVersion { get; set; }

        [JsonPropertyName("linuxFxVersion")]
        public string LinuxFxVersion { get; set; }

        [JsonPropertyName("windowsFxVersion")]
        public object WindowsFxVersion { get; set; }

        [JsonPropertyName("windowsConfiguredStacks")]
        public object WindowsConfiguredStacks { get; set; }

        [JsonPropertyName("requestTracingEnabled")]
        public object RequestTracingEnabled { get; set; }

        [JsonPropertyName("remoteDebuggingEnabled")]
        public object RemoteDebuggingEnabled { get; set; }

        [JsonPropertyName("remoteDebuggingVersion")]
        public object RemoteDebuggingVersion { get; set; }

        [JsonPropertyName("httpLoggingEnabled")]
        public object HttpLoggingEnabled { get; set; }

        [JsonPropertyName("azureMonitorLogCategories")]
        public object AzureMonitorLogCategories { get; set; }

        [JsonPropertyName("acrUseManagedIdentityCreds")]
        public bool AcrUseManagedIdentityCreds { get; set; }

        [JsonPropertyName("acrUserManagedIdentityID")]
        public object AcrUserManagedIdentityID { get; set; }

        [JsonPropertyName("logsDirectorySizeLimit")]
        public object LogsDirectorySizeLimit { get; set; }

        [JsonPropertyName("detailedErrorLoggingEnabled")]
        public object DetailedErrorLoggingEnabled { get; set; }

        [JsonPropertyName("publishingUsername")]
        public object PublishingUsername { get; set; }

        [JsonPropertyName("publishingPassword")]
        public object PublishingPassword { get; set; }

        [JsonPropertyName("appSettings")]
        public object AppSettings { get; set; }

        [JsonPropertyName("metadata")]
        public object Metadata { get; set; }

        [JsonPropertyName("connectionStrings")]
        public object ConnectionStrings { get; set; }

        [JsonPropertyName("machineKey")]
        public object MachineKey { get; set; }

        [JsonPropertyName("handlerMappings")]
        public object HandlerMappings { get; set; }

        [JsonPropertyName("documentRoot")]
        public object DocumentRoot { get; set; }

        [JsonPropertyName("scmType")]
        public object ScmType { get; set; }

        [JsonPropertyName("use32BitWorkerProcess")]
        public object Use32BitWorkerProcess { get; set; }

        [JsonPropertyName("webSocketsEnabled")]
        public object WebSocketsEnabled { get; set; }

        [JsonPropertyName("alwaysOn")]
        public bool AlwaysOn { get; set; }

        [JsonPropertyName("javaVersion")]
        public object JavaVersion { get; set; }

        [JsonPropertyName("javaContainer")]
        public object JavaContainer { get; set; }

        [JsonPropertyName("javaContainerVersion")]
        public object JavaContainerVersion { get; set; }

        [JsonPropertyName("appCommandLine")]
        public object AppCommandLine { get; set; }

        [JsonPropertyName("managedPipelineMode")]
        public object ManagedPipelineMode { get; set; }

        [JsonPropertyName("virtualApplications")]
        public object VirtualApplications { get; set; }

        [JsonPropertyName("winAuthAdminState")]
        public object WinAuthAdminState { get; set; }

        [JsonPropertyName("winAuthTenantState")]
        public object WinAuthTenantState { get; set; }

        [JsonPropertyName("customAppPoolIdentityAdminState")]
        public object CustomAppPoolIdentityAdminState { get; set; }

        [JsonPropertyName("customAppPoolIdentityTenantState")]
        public object CustomAppPoolIdentityTenantState { get; set; }

        [JsonPropertyName("runtimeADUser")]
        public object RuntimeADUser { get; set; }

        [JsonPropertyName("runtimeADUserPassword")]
        public object RuntimeADUserPassword { get; set; }

        [JsonPropertyName("loadBalancing")]
        public object LoadBalancing { get; set; }

        [JsonPropertyName("routingRules")]
        public object RoutingRules { get; set; }

        [JsonPropertyName("experiments")]
        public object Experiments { get; set; }

        [JsonPropertyName("limits")]
        public object Limits { get; set; }

        [JsonPropertyName("autoHealEnabled")]
        public object AutoHealEnabled { get; set; }

        [JsonPropertyName("autoHealRules")]
        public object AutoHealRules { get; set; }

        [JsonPropertyName("tracingOptions")]
        public object TracingOptions { get; set; }

        [JsonPropertyName("vnetName")]
        public object VnetName { get; set; }

        [JsonPropertyName("vnetRouteAllEnabled")]
        public object VnetRouteAllEnabled { get; set; }

        [JsonPropertyName("vnetPrivatePortsCount")]
        public object VnetPrivatePortsCount { get; set; }

        [JsonPropertyName("publicNetworkAccess")]
        public object PublicNetworkAccess { get; set; }

        [JsonPropertyName("cors")]
        public object Cors { get; set; }

        [JsonPropertyName("push")]
        public object Push { get; set; }

        [JsonPropertyName("apiDefinition")]
        public object ApiDefinition { get; set; }

        [JsonPropertyName("apiManagementConfig")]
        public object ApiManagementConfig { get; set; }

        [JsonPropertyName("autoSwapSlotName")]
        public object AutoSwapSlotName { get; set; }

        [JsonPropertyName("localMySqlEnabled")]
        public object LocalMySqlEnabled { get; set; }

        [JsonPropertyName("managedServiceIdentityId")]
        public object ManagedServiceIdentityId { get; set; }

        [JsonPropertyName("xManagedServiceIdentityId")]
        public object XManagedServiceIdentityId { get; set; }

        [JsonPropertyName("keyVaultReferenceIdentity")]
        public object KeyVaultReferenceIdentity { get; set; }

        [JsonPropertyName("ipSecurityRestrictions")]
        public object IpSecurityRestrictions { get; set; }

        [JsonPropertyName("ipSecurityRestrictionsDefaultAction")]
        public object IpSecurityRestrictionsDefaultAction { get; set; }

        [JsonPropertyName("scmIpSecurityRestrictions")]
        public object ScmIpSecurityRestrictions { get; set; }

        [JsonPropertyName("scmIpSecurityRestrictionsDefaultAction")]
        public object ScmIpSecurityRestrictionsDefaultAction { get; set; }

        [JsonPropertyName("scmIpSecurityRestrictionsUseMain")]
        public object ScmIpSecurityRestrictionsUseMain { get; set; }

        [JsonPropertyName("http20Enabled")]
        public bool Http20Enabled { get; set; }

        [JsonPropertyName("minTlsVersion")]
        public object MinTlsVersion { get; set; }

        [JsonPropertyName("minTlsCipherSuite")]
        public object MinTlsCipherSuite { get; set; }

        [JsonPropertyName("supportedTlsCipherSuites")]
        public object SupportedTlsCipherSuites { get; set; }

        [JsonPropertyName("scmMinTlsVersion")]
        public object ScmMinTlsVersion { get; set; }

        [JsonPropertyName("ftpsState")]
        public object FtpsState { get; set; }

        [JsonPropertyName("preWarmedInstanceCount")]
        public object PreWarmedInstanceCount { get; set; }

        [JsonPropertyName("functionAppScaleLimit")]
        public int FunctionAppScaleLimit { get; set; }

        [JsonPropertyName("elasticWebAppScaleLimit")]
        public object ElasticWebAppScaleLimit { get; set; }

        [JsonPropertyName("healthCheckPath")]
        public object HealthCheckPath { get; set; }

        [JsonPropertyName("fileChangeAuditEnabled")]
        public object FileChangeAuditEnabled { get; set; }

        [JsonPropertyName("functionsRuntimeScaleMonitoringEnabled")]
        public object FunctionsRuntimeScaleMonitoringEnabled { get; set; }

        [JsonPropertyName("websiteTimeZone")]
        public object WebsiteTimeZone { get; set; }

        [JsonPropertyName("minimumElasticInstanceCount")]
        public int MinimumElasticInstanceCount { get; set; }

        [JsonPropertyName("azureStorageAccounts")]
        public object AzureStorageAccounts { get; set; }

        [JsonPropertyName("http20ProxyFlag")]
        public object Http20ProxyFlag { get; set; }

        [JsonPropertyName("sitePort")]
        public object SitePort { get; set; }

        [JsonPropertyName("antivirusScanEnabled")]
        public object AntivirusScanEnabled { get; set; }

        [JsonPropertyName("storageType")]
        public object StorageType { get; set; }
    }

    public class SiteProperties
    {
        [JsonPropertyName("metadata")]
        public object Metadata { get; set; }

        [JsonPropertyName("properties")]
        public List<Property> Properties { get; set; }

        [JsonPropertyName("appSettings")]
        public object AppSettings { get; set; }
    }

    public class Tags
    {
    }

    public class Value
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
        public PropertiesCertificate Properties { get; set; }
    }

    public class PropertiesCertificate
    {
        [JsonPropertyName("password")]
        public object Password { get; set; }

        [JsonPropertyName("friendlyName")]
        public string FriendlyName { get; set; }

        [JsonPropertyName("subjectName")]
        public string SubjectName { get; set; }

        [JsonPropertyName("hostNames")]
        public List<string> HostNames { get; set; }

        [JsonPropertyName("pfxBlob")]
        public object PfxBlob { get; set; }

        [JsonPropertyName("siteName")]
        public object SiteName { get; set; }

        [JsonPropertyName("selfLink")]
        public object SelfLink { get; set; }

        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("issueDate")]
        public DateTime IssueDate { get; set; }

        [JsonPropertyName("expirationDate")]
        public DateTime ExpirationDate { get; set; }

        [JsonPropertyName("thumbprint")]
        public string Thumbprint { get; set; }

        [JsonPropertyName("valid")]
        public object Valid { get; set; }

        [JsonPropertyName("toDelete")]
        public object ToDelete { get; set; }

        [JsonPropertyName("cerBlob")]
        public object CerBlob { get; set; }

        [JsonPropertyName("publicKeyHash")]
        public object PublicKeyHash { get; set; }

        [JsonPropertyName("hostingEnvironment")]
        public object HostingEnvironment { get; set; }

        [JsonPropertyName("hostingEnvironmentProfile")]
        public object HostingEnvironmentProfile { get; set; }

        [JsonPropertyName("keyVaultId")]
        public string KeyVaultId { get; set; }

        [JsonPropertyName("keyVaultSecretName")]
        public string KeyVaultSecretName { get; set; }

        [JsonPropertyName("keyVaultSecretStatus")]
        public string KeyVaultSecretStatus { get; set; }

        [JsonPropertyName("webSpace")]
        public string WebSpace { get; set; }

        [JsonPropertyName("serverFarmId")]
        public object ServerFarmId { get; set; }

        [JsonPropertyName("canonicalName")]
        public string CanonicalName { get; set; }

        [JsonPropertyName("tags")]
        public object Tags { get; set; }

        [JsonPropertyName("resourceGroup")]
        public string ResourceGroup { get; set; }
    }

    public class ARecords
    {
        [JsonPropertyName("@xmlns:d2p1")]
        public string XmlnsD2p1 { get; set; }

        [JsonPropertyName("d2p1:string")]
        public string D2p1String { get; set; }
    }

    public class CNameRecords
    {
        [JsonPropertyName("@xmlns:d2p1")]
        public string XmlnsD2p1 { get; set; }

        [JsonPropertyName("d2p1:string")]
        public string D2p1String { get; set; }
    }

    public class CustomDomainVerificationFailureInfo
    {
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        [JsonPropertyName("Message")]
        public string Message { get; set; }

        [JsonPropertyName("ExtendedCode")]
        public string ExtendedCode { get; set; }

        [JsonPropertyName("MessageTemplate")]
        public string MessageTemplate { get; set; }

        [JsonPropertyName("Parameters")]
        public Parameters Parameters { get; set; }

        [JsonPropertyName("InnerErrors")]
        public InnerErrors InnerErrors { get; set; }

        [JsonPropertyName("Details")]
        public Details Details { get; set; }

        [JsonPropertyName("Target")]
        public Target Target { get; set; }
    }

    public class Details
    {
        [JsonPropertyName("@i:nil")]
        public string INil { get; set; }
    }

    public class InnerErrors
    {
        [JsonPropertyName("@i:nil")]
        public string INil { get; set; }
    }

    public class Parameters
    {
        [JsonPropertyName("@xmlns:d3p1")]
        public string XmlnsD3p1 { get; set; }

        [JsonPropertyName("d3p1:string")]
        public List<string> D3p1String { get; set; }
    }

    public class Target
    {
        [JsonPropertyName("@i:nil")]
        public string INil { get; set; }
    }
}
