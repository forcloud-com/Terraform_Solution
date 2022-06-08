using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworks.OpsworksInstanceEphemeralBlockDevice")]
    public class OpsworksInstanceEphemeralBlockDevice : aws.Opsworks.IOpsworksInstanceEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#device_name OpsworksInstance#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#virtual_name OpsworksInstance#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualName
        {
            get;
            set;
        }
    }
}
