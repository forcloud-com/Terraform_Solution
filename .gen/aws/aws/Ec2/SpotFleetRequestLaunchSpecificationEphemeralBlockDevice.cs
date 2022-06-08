using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.SpotFleetRequestLaunchSpecificationEphemeralBlockDevice")]
    public class SpotFleetRequestLaunchSpecificationEphemeralBlockDevice : aws.Ec2.ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#device_name SpotFleetRequest#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#virtual_name SpotFleetRequest#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualName
        {
            get;
            set;
        }
    }
}
