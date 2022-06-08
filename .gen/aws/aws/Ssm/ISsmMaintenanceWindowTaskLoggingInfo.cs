using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskLoggingInfo), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskLoggingInfo")]
    public interface ISsmMaintenanceWindowTaskLoggingInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#s3_bucket_name SsmMaintenanceWindowTask#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        string S3BucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#s3_region SsmMaintenanceWindowTask#s3_region}.</summary>
        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
        string S3Region
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#s3_bucket_prefix SsmMaintenanceWindowTask#s3_bucket_prefix}.</summary>
        [JsiiProperty(name: "s3BucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BucketPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskLoggingInfo), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskLoggingInfo")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.ISsmMaintenanceWindowTaskLoggingInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#s3_bucket_name SsmMaintenanceWindowTask#s3_bucket_name}.</summary>
            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string S3BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#s3_region SsmMaintenanceWindowTask#s3_region}.</summary>
            [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#s3_bucket_prefix SsmMaintenanceWindowTask#s3_bucket_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3BucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BucketPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
