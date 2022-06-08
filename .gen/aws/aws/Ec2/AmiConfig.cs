using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    /// <summary>AWS EC2.</summary>
    [JsiiByValue(fqn: "aws.ec2.AmiConfig")]
    public class AmiConfig : aws.Ec2.IAmiConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#name Ami#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#architecture Ami#architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Architecture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#description Ami#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>ebs_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#ebs_block_device Ami#ebs_block_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.AmiEbsBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EbsBlockDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#ena_support Ami#ena_support}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enaSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnaSupport
        {
            get;
            set;
        }

        /// <summary>ephemeral_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#ephemeral_block_device Ami#ephemeral_block_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.AmiEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EphemeralBlockDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#image_location Ami#image_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#kernel_id Ami#kernel_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KernelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#ramdisk_id Ami#ramdisk_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ramdiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RamdiskId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#root_device_name Ami#root_device_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootDeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#sriov_net_support Ami#sriov_net_support}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sriovNetSupport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SriovNetSupport
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#tags Ami#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#timeouts Ami#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.AmiTimeouts\"}", isOptional: true)]
        public aws.Ec2.IAmiTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#virtualization_type Ami#virtualization_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualizationType
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
