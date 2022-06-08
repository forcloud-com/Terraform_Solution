using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    [JsiiInterface(nativeType: typeof(IGlobalacceleratorEndpointGroupEndpointConfiguration), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorEndpointGroupEndpointConfiguration")]
    public interface IGlobalacceleratorEndpointGroupEndpointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#endpoint_id GlobalacceleratorEndpointGroup#endpoint_id}.</summary>
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#weight GlobalacceleratorEndpointGroup#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlobalacceleratorEndpointGroupEndpointConfiguration), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorEndpointGroupEndpointConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Globalaccelerator.IGlobalacceleratorEndpointGroupEndpointConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#endpoint_id GlobalacceleratorEndpointGroup#endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#weight GlobalacceleratorEndpointGroup#weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
