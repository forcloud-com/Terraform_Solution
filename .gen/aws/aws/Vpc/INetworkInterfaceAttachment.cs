using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiInterface(nativeType: typeof(INetworkInterfaceAttachment), fullyQualifiedName: "aws.vpc.NetworkInterfaceAttachment")]
    public interface INetworkInterfaceAttachment
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_interface#device_index NetworkInterface#device_index}.</summary>
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
        double DeviceIndex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_interface#instance NetworkInterface#instance}.</summary>
        [JsiiProperty(name: "instance", typeJson: "{\"primitive\":\"string\"}")]
        string Instance
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkInterfaceAttachment), fullyQualifiedName: "aws.vpc.NetworkInterfaceAttachment")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.INetworkInterfaceAttachment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_interface#device_index NetworkInterface#device_index}.</summary>
            [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
            public double DeviceIndex
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_interface#instance NetworkInterface#instance}.</summary>
            [JsiiProperty(name: "instance", typeJson: "{\"primitive\":\"string\"}")]
            public string Instance
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
