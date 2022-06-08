using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.servicediscovery.ServiceDiscoveryServiceDnsConfig")]
    public class ServiceDiscoveryServiceDnsConfig : aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig
    {
        /// <summary>dns_records block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#dns_records ServiceDiscoveryService#dns_records}
        /// </remarks>
        [JsiiProperty(name: "dnsRecords", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}]}}")]
        public object DnsRecords
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#namespace_id ServiceDiscoveryService#namespace_id}.</summary>
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string NamespaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#routing_policy ServiceDiscoveryService#routing_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingPolicy
        {
            get;
            set;
        }
    }
}
