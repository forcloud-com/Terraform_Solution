using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(IInstanceNetworkInterface), fullyQualifiedName: "aws.ec2.InstanceNetworkInterface")]
    public interface IInstanceNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#device_index Instance#device_index}.</summary>
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
        double DeviceIndex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#network_interface_id Instance#network_interface_id}.</summary>
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkInterfaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#delete_on_termination Instance#delete_on_termination}.</summary>
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteOnTermination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceNetworkInterface), fullyQualifiedName: "aws.ec2.InstanceNetworkInterface")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IInstanceNetworkInterface
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#device_index Instance#device_index}.</summary>
            [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
            public double DeviceIndex
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#network_interface_id Instance#network_interface_id}.</summary>
            [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkInterfaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#delete_on_termination Instance#delete_on_termination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteOnTermination
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
