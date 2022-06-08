using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.SpotInstanceRequestEphemeralBlockDevice")]
    public class SpotInstanceRequestEphemeralBlockDevice : aws.Ec2.ISpotInstanceRequestEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#device_name SpotInstanceRequest#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#no_device SpotInstanceRequest#no_device}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? NoDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#virtual_name SpotInstanceRequest#virtual_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualName
        {
            get;
            set;
        }
    }
}
