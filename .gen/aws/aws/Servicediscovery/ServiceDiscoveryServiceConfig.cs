using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    #pragma warning disable CS8618

    /// <summary>AWS Service Discovery.</summary>
    [JsiiByValue(fqn: "aws.servicediscovery.ServiceDiscoveryServiceConfig")]
    public class ServiceDiscoveryServiceConfig : aws.Servicediscovery.IServiceDiscoveryServiceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#name ServiceDiscoveryService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#description ServiceDiscoveryService#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>dns_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#dns_config ServiceDiscoveryService#dns_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfig\"}", isOptional: true)]
        public aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig? DnsConfig
        {
            get;
            set;
        }

        /// <summary>health_check_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#health_check_config ServiceDiscoveryService#health_check_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckConfig\"}", isOptional: true)]
        public aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig? HealthCheckConfig
        {
            get;
            set;
        }

        /// <summary>health_check_custom_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#health_check_custom_config ServiceDiscoveryService#health_check_custom_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckCustomConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfig\"}", isOptional: true)]
        public aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig? HealthCheckCustomConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#namespace_id ServiceDiscoveryService#namespace_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamespaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#tags ServiceDiscoveryService#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
