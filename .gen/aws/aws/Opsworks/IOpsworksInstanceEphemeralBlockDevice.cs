using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    [JsiiInterface(nativeType: typeof(IOpsworksInstanceEphemeralBlockDevice), fullyQualifiedName: "aws.opsworks.OpsworksInstanceEphemeralBlockDevice")]
    public interface IOpsworksInstanceEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#device_name OpsworksInstance#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#virtual_name OpsworksInstance#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksInstanceEphemeralBlockDevice), fullyQualifiedName: "aws.opsworks.OpsworksInstanceEphemeralBlockDevice")]
        internal sealed class _Proxy : DeputyBase, aws.Opsworks.IOpsworksInstanceEphemeralBlockDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#device_name OpsworksInstance#device_name}.</summary>
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#virtual_name OpsworksInstance#virtual_name}.</summary>
            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
