using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    [JsiiByValue(fqn: "aws.servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfig")]
    public class ServiceDiscoveryServiceHealthCheckCustomConfig : aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#failure_threshold ServiceDiscoveryService#failure_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }
    }
}
