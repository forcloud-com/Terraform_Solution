using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    [JsiiInterface(nativeType: typeof(IServiceDiscoveryServiceDnsConfig), fullyQualifiedName: "aws.servicediscovery.ServiceDiscoveryServiceDnsConfig")]
    public interface IServiceDiscoveryServiceDnsConfig
    {
        /// <summary>dns_records block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#dns_records ServiceDiscoveryService#dns_records}
        /// </remarks>
        [JsiiProperty(name: "dnsRecords", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}]}}")]
        object DnsRecords
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#namespace_id ServiceDiscoveryService#namespace_id}.</summary>
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        string NamespaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#routing_policy ServiceDiscoveryService#routing_policy}.</summary>
        [JsiiProperty(name: "routingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceDiscoveryServiceDnsConfig), fullyQualifiedName: "aws.servicediscovery.ServiceDiscoveryServiceDnsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dns_records block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#dns_records ServiceDiscoveryService#dns_records}
            /// </remarks>
            [JsiiProperty(name: "dnsRecords", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}]}}")]
            public object DnsRecords
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#namespace_id ServiceDiscoveryService#namespace_id}.</summary>
            [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string NamespaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#routing_policy ServiceDiscoveryService#routing_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
