using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiByValue(fqn: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters : aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#comment SsmMaintenanceWindowTask#comment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Comment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#document_hash SsmMaintenanceWindowTask#document_hash}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentHash
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#document_hash_type SsmMaintenanceWindowTask#document_hash_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentHashType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentHashType
        {
            get;
            set;
        }

        /// <summary>notification_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#notification_config SsmMaintenanceWindowTask#notification_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notificationConfig", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig\"}", isOptional: true)]
        public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig? NotificationConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#output_s3_bucket SsmMaintenanceWindowTask#output_s3_bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputS3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#output_s3_key_prefix SsmMaintenanceWindowTask#output_s3_key_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputS3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputS3KeyPrefix
        {
            get;
            set;
        }

        /// <summary>parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#parameter SsmMaintenanceWindowTask#parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parameter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#service_role_arn SsmMaintenanceWindowTask#service_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#timeout_seconds SsmMaintenanceWindowTask#timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutSeconds
        {
            get;
            set;
        }
    }
}
