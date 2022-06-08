using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    [JsiiInterface(nativeType: typeof(IServiceDiscoveryServiceHealthCheckConfig), fullyQualifiedName: "aws.servicediscovery.ServiceDiscoveryServiceHealthCheckConfig")]
    public interface IServiceDiscoveryServiceHealthCheckConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#failure_threshold ServiceDiscoveryService#failure_threshold}.</summary>
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#resource_path ServiceDiscoveryService#resource_path}.</summary>
        [JsiiProperty(name: "resourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourcePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#type ServiceDiscoveryService#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceDiscoveryServiceHealthCheckConfig), fullyQualifiedName: "aws.servicediscovery.ServiceDiscoveryServiceHealthCheckConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#failure_threshold ServiceDiscoveryService#failure_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#resource_path ServiceDiscoveryService#resource_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourcePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service#type ServiceDiscoveryService#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
