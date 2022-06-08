using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    [JsiiByValue(fqn: "aws.servicediscovery.ServiceDiscoveryServiceHealthCheckConfig")]
    public class ServiceDiscoveryServiceHealthCheckConfig : aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#failure_threshold ServiceDiscoveryService#failure_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#resource_path ServiceDiscoveryService#resource_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourcePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#type ServiceDiscoveryService#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
