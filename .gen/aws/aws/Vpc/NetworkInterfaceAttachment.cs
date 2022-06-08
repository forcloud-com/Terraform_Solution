using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpc.NetworkInterfaceAttachment")]
    public class NetworkInterfaceAttachment : aws.Vpc.INetworkInterfaceAttachment
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_interface#device_index NetworkInterface#device_index}.</summary>
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
        public double DeviceIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_interface#instance NetworkInterface#instance}.</summary>
        [JsiiProperty(name: "instance", typeJson: "{\"primitive\":\"string\"}")]
        public string Instance
        {
            get;
            set;
        }
    }
}
