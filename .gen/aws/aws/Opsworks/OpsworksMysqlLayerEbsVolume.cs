using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworks.OpsworksMysqlLayerEbsVolume")]
    public class OpsworksMysqlLayerEbsVolume : aws.Opsworks.IOpsworksMysqlLayerEbsVolume
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_mysql_layer#mount_point OpsworksMysqlLayer#mount_point}.</summary>
        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}")]
        public string MountPoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_mysql_layer#number_of_disks OpsworksMysqlLayer#number_of_disks}.</summary>
        [JsiiProperty(name: "numberOfDisks", typeJson: "{\"primitive\":\"number\"}")]
        public double NumberOfDisks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_mysql_layer#size OpsworksMysqlLayer#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_mysql_layer#encrypted OpsworksMysqlLayer#encrypted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Encrypted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_mysql_layer#iops OpsworksMysqlLayer#iops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Iops
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_mysql_layer#raid_level OpsworksMysqlLayer#raid_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "raidLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RaidLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_mysql_layer#type OpsworksMysqlLayer#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
