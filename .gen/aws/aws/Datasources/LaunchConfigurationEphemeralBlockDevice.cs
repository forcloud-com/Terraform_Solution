using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasources.LaunchConfigurationEphemeralBlockDevice")]
    public class LaunchConfigurationEphemeralBlockDevice : aws.Datasources.ILaunchConfigurationEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#device_name LaunchConfiguration#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#virtual_name LaunchConfiguration#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualName
        {
            get;
            set;
        }
    }
}
