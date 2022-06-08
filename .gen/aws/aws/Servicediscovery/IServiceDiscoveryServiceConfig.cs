using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    /// <summary>AWS Service Discovery.</summary>
    [JsiiInterface(nativeType: typeof(IServiceDiscoveryServiceConfig), fullyQualifiedName: "aws.servicediscovery.ServiceDiscoveryServiceConfig")]
    public interface IServiceDiscoveryServiceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#name ServiceDiscoveryService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#description ServiceDiscoveryService#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dns_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#dns_config ServiceDiscoveryService#dns_config}
        /// </remarks>
        [JsiiProperty(name: "dnsConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig? DnsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#health_check_config ServiceDiscoveryService#health_check_config}
        /// </remarks>
        [JsiiProperty(name: "healthCheckConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig? HealthCheckConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check_custom_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#health_check_custom_config ServiceDiscoveryService#health_check_custom_config}
        /// </remarks>
        [JsiiProperty(name: "healthCheckCustomConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig? HealthCheckCustomConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#namespace_id ServiceDiscoveryService#namespace_id}.</summary>
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamespaceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#tags ServiceDiscoveryService#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Service Discovery.</summary>
        [JsiiTypeProxy(nativeType: typeof(IServiceDiscoveryServiceConfig), fullyQualifiedName: "aws.servicediscovery.ServiceDiscoveryServiceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Servicediscovery.IServiceDiscoveryServiceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#name ServiceDiscoveryService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#description ServiceDiscoveryService#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dns_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#dns_config ServiceDiscoveryService#dns_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfig\"}", isOptional: true)]
            public aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig? DnsConfig
            {
                get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig?>();
            }

            /// <summary>health_check_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#health_check_config ServiceDiscoveryService#health_check_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckConfig\"}", isOptional: true)]
            public aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig? HealthCheckConfig
            {
                get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig?>();
            }

            /// <summary>health_check_custom_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#health_check_custom_config ServiceDiscoveryService#health_check_custom_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckCustomConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfig\"}", isOptional: true)]
            public aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig? HealthCheckCustomConfig
            {
                get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#namespace_id ServiceDiscoveryService#namespace_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamespaceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#tags ServiceDiscoveryService#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
