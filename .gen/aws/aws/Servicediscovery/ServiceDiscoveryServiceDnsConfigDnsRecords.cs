using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.servicediscovery.ServiceDiscoveryServiceDnsConfigDnsRecords")]
    public class ServiceDiscoveryServiceDnsConfigDnsRecords : aws.Servicediscovery.IServiceDiscoveryServiceDnsConfigDnsRecords
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#ttl ServiceDiscoveryService#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public double Ttl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#type ServiceDiscoveryService#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
