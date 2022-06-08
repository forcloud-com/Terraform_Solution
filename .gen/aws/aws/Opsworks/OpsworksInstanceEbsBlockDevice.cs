using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworks.OpsworksInstanceEbsBlockDevice")]
    public class OpsworksInstanceEbsBlockDevice : aws.Opsworks.IOpsworksInstanceEbsBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#device_name OpsworksInstance#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#delete_on_termination OpsworksInstance#delete_on_termination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteOnTermination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#iops OpsworksInstance#iops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Iops
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#snapshot_id OpsworksInstance#snapshot_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#volume_size OpsworksInstance#volume_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VolumeSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#volume_type OpsworksInstance#volume_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeType
        {
            get;
            set;
        }
    }
}
