using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestNetworkInterface), fullyQualifiedName: "aws.ec2.SpotInstanceRequestNetworkInterface")]
    public interface ISpotInstanceRequestNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#device_index SpotInstanceRequest#device_index}.</summary>
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
        double DeviceIndex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#network_interface_id SpotInstanceRequest#network_interface_id}.</summary>
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkInterfaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#delete_on_termination SpotInstanceRequest#delete_on_termination}.</summary>
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteOnTermination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestNetworkInterface), fullyQualifiedName: "aws.ec2.SpotInstanceRequestNetworkInterface")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotInstanceRequestNetworkInterface
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#device_index SpotInstanceRequest#device_index}.</summary>
            [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
            public double DeviceIndex
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#network_interface_id SpotInstanceRequest#network_interface_id}.</summary>
            [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkInterfaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#delete_on_termination SpotInstanceRequest#delete_on_termination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteOnTermination
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
