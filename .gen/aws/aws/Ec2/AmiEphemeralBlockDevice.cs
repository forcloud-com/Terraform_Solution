using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.AmiEphemeralBlockDevice")]
    public class AmiEphemeralBlockDevice : aws.Ec2.IAmiEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#device_name Ami#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#virtual_name Ami#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualName
        {
            get;
            set;
        }
    }
}
