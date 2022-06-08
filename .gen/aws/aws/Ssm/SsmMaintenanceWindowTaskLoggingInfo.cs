using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssm.SsmMaintenanceWindowTaskLoggingInfo")]
    public class SsmMaintenanceWindowTaskLoggingInfo : aws.Ssm.ISsmMaintenanceWindowTaskLoggingInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#s3_bucket_name SsmMaintenanceWindowTask#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string S3BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#s3_region SsmMaintenanceWindowTask#s3_region}.</summary>
        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#s3_bucket_prefix SsmMaintenanceWindowTask#s3_bucket_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3BucketPrefix
        {
            get;
            set;
        }
    }
}
