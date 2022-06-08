using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    [JsiiInterface(nativeType: typeof(ILaunchConfigurationEphemeralBlockDevice), fullyQualifiedName: "aws.datasources.LaunchConfigurationEphemeralBlockDevice")]
    public interface ILaunchConfigurationEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#device_name LaunchConfiguration#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#virtual_name LaunchConfiguration#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchConfigurationEphemeralBlockDevice), fullyQualifiedName: "aws.datasources.LaunchConfigurationEphemeralBlockDevice")]
        internal sealed class _Proxy : DeputyBase, aws.Datasources.ILaunchConfigurationEphemeralBlockDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#device_name LaunchConfiguration#device_name}.</summary>
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#virtual_name LaunchConfiguration#virtual_name}.</summary>
            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
