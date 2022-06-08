using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.InstanceNetworkInterface")]
    public class InstanceNetworkInterface : aws.Ec2.IInstanceNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#device_index Instance#device_index}.</summary>
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
        public double DeviceIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#network_interface_id Instance#network_interface_id}.</summary>
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkInterfaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#delete_on_termination Instance#delete_on_termination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteOnTermination
        {
            get;
            set;
        }
    }
}
