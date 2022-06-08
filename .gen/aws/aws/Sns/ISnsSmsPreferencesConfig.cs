using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sns
{
    /// <summary>AWS Simple Notification Service.</summary>
    [JsiiInterface(nativeType: typeof(ISnsSmsPreferencesConfig), fullyQualifiedName: "aws.sns.SnsSmsPreferencesConfig")]
    public interface ISnsSmsPreferencesConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#default_sender_id SnsSmsPreferences#default_sender_id}.</summary>
        [JsiiProperty(name: "defaultSenderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSenderId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#default_sms_type SnsSmsPreferences#default_sms_type}.</summary>
        [JsiiProperty(name: "defaultSmsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSmsType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#delivery_status_iam_role_arn SnsSmsPreferences#delivery_status_iam_role_arn}.</summary>
        [JsiiProperty(name: "deliveryStatusIamRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryStatusIamRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#delivery_status_success_sampling_rate SnsSmsPreferences#delivery_status_success_sampling_rate}.</summary>
        [JsiiProperty(name: "deliveryStatusSuccessSamplingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryStatusSuccessSamplingRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#monthly_spend_limit SnsSmsPreferences#monthly_spend_limit}.</summary>
        [JsiiProperty(name: "monthlySpendLimit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MonthlySpendLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#usage_report_s3_bucket SnsSmsPreferences#usage_report_s3_bucket}.</summary>
        [JsiiProperty(name: "usageReportS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageReportS3Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Notification Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISnsSmsPreferencesConfig), fullyQualifiedName: "aws.sns.SnsSmsPreferencesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sns.ISnsSmsPreferencesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#default_sender_id SnsSmsPreferences#default_sender_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultSenderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSenderId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#default_sms_type SnsSmsPreferences#default_sms_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultSmsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSmsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#delivery_status_iam_role_arn SnsSmsPreferences#delivery_status_iam_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryStatusIamRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryStatusIamRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#delivery_status_success_sampling_rate SnsSmsPreferences#delivery_status_success_sampling_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryStatusSuccessSamplingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryStatusSuccessSamplingRate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#monthly_spend_limit SnsSmsPreferences#monthly_spend_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monthlySpendLimit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MonthlySpendLimit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences#usage_report_s3_bucket SnsSmsPreferences#usage_report_s3_bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usageReportS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageReportS3Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
