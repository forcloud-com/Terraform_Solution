using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice), fullyQualifiedName: "aws.ec2.SpotFleetRequestLaunchSpecificationEphemeralBlockDevice")]
    public interface ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#device_name SpotFleetRequest#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#virtual_name SpotFleetRequest#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice), fullyQualifiedName: "aws.ec2.SpotFleetRequestLaunchSpecificationEphemeralBlockDevice")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#device_name SpotFleetRequest#device_name}.</summary>
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#virtual_name SpotFleetRequest#virtual_name}.</summary>
            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
