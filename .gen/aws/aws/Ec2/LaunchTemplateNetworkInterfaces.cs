using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateNetworkInterfaces")]
    public class LaunchTemplateNetworkInterfaces : aws.Ec2.ILaunchTemplateNetworkInterfaces
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#associate_public_ip_address LaunchTemplate#associate_public_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssociatePublicIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#delete_on_termination LaunchTemplate#delete_on_termination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteOnTermination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#description LaunchTemplate#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#device_index LaunchTemplate#device_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeviceIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ipv4_address_count LaunchTemplate#ipv4_address_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ipv4AddressCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ipv4_addresses LaunchTemplate#ipv4_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ipv4Addresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ipv6_address_count LaunchTemplate#ipv6_address_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ipv6AddressCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ipv6_addresses LaunchTemplate#ipv6_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ipv6Addresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#network_interface_id LaunchTemplate#network_interface_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkInterfaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#private_ip_address LaunchTemplate#private_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#security_groups LaunchTemplate#security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#subnet_id LaunchTemplate#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
