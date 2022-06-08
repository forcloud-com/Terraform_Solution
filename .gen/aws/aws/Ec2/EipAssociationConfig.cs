using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiByValue(fqn: "aws.ec2.EipAssociationConfig")]
    public class EipAssociationConfig : aws.Ec2.IEipAssociationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eip_association#allocation_id EipAssociation#allocation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllocationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eip_association#allow_reassociation EipAssociation#allow_reassociation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowReassociation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowReassociation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eip_association#instance_id EipAssociation#instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eip_association#network_interface_id EipAssociation#network_interface_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkInterfaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eip_association#private_ip_address EipAssociation#private_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eip_association#public_ip EipAssociation#public_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicIp
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
