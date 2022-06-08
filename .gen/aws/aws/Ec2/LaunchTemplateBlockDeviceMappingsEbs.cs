using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateBlockDeviceMappingsEbs")]
    public class LaunchTemplateBlockDeviceMappingsEbs : aws.Ec2.ILaunchTemplateBlockDeviceMappingsEbs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#delete_on_termination LaunchTemplate#delete_on_termination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeleteOnTermination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#encrypted LaunchTemplate#encrypted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Encrypted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#iops LaunchTemplate#iops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Iops
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#kms_key_id LaunchTemplate#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#snapshot_id LaunchTemplate#snapshot_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#volume_size LaunchTemplate#volume_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VolumeSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#volume_type LaunchTemplate#volume_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeType
        {
            get;
            set;
        }
    }
}
