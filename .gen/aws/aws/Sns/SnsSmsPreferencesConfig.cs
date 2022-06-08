using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sns
{
    /// <summary>AWS Simple Notification Service.</summary>
    [JsiiByValue(fqn: "aws.sns.SnsSmsPreferencesConfig")]
    public class SnsSmsPreferencesConfig : aws.Sns.ISnsSmsPreferencesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#default_sender_id SnsSmsPreferences#default_sender_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultSenderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultSenderId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#default_sms_type SnsSmsPreferences#default_sms_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultSmsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultSmsType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#delivery_status_iam_role_arn SnsSmsPreferences#delivery_status_iam_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deliveryStatusIamRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeliveryStatusIamRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#delivery_status_success_sampling_rate SnsSmsPreferences#delivery_status_success_sampling_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deliveryStatusSuccessSamplingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeliveryStatusSuccessSamplingRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#monthly_spend_limit SnsSmsPreferences#monthly_spend_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monthlySpendLimit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MonthlySpendLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#usage_report_s3_bucket SnsSmsPreferences#usage_report_s3_bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usageReportS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsageReportS3Bucket
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
