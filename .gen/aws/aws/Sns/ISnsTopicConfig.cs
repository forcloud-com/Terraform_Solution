using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sns
{
    /// <summary>AWS Simple Notification Service.</summary>
    [JsiiInterface(nativeType: typeof(ISnsTopicConfig), fullyQualifiedName: "aws.sns.SnsTopicConfig")]
    public interface ISnsTopicConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#application_failure_feedback_role_arn SnsTopic#application_failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "applicationFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationFailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#application_success_feedback_role_arn SnsTopic#application_success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "applicationSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationSuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#application_success_feedback_sample_rate SnsTopic#application_success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "applicationSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ApplicationSuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#delivery_policy SnsTopic#delivery_policy}.</summary>
        [JsiiProperty(name: "deliveryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#display_name SnsTopic#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#http_failure_feedback_role_arn SnsTopic#http_failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "httpFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpFailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#http_success_feedback_role_arn SnsTopic#http_success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "httpSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpSuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#http_success_feedback_sample_rate SnsTopic#http_success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "httpSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpSuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#kms_master_key_id SnsTopic#kms_master_key_id}.</summary>
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsMasterKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#lambda_failure_feedback_role_arn SnsTopic#lambda_failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "lambdaFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LambdaFailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#lambda_success_feedback_role_arn SnsTopic#lambda_success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "lambdaSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LambdaSuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#lambda_success_feedback_sample_rate SnsTopic#lambda_success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "lambdaSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LambdaSuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#name SnsTopic#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#name_prefix SnsTopic#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#policy SnsTopic#policy}.</summary>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#sqs_failure_feedback_role_arn SnsTopic#sqs_failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "sqsFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqsFailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#sqs_success_feedback_role_arn SnsTopic#sqs_success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "sqsSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqsSuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#sqs_success_feedback_sample_rate SnsTopic#sqs_success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "sqsSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SqsSuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#tags SnsTopic#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Notification Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISnsTopicConfig), fullyQualifiedName: "aws.sns.SnsTopicConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sns.ISnsTopicConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#application_failure_feedback_role_arn SnsTopic#application_failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationFailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#application_success_feedback_role_arn SnsTopic#application_success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationSuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#application_success_feedback_sample_rate SnsTopic#application_success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ApplicationSuccessFeedbackSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#delivery_policy SnsTopic#delivery_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#display_name SnsTopic#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#http_failure_feedback_role_arn SnsTopic#http_failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpFailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#http_success_feedback_role_arn SnsTopic#http_success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpSuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#http_success_feedback_sample_rate SnsTopic#http_success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpSuccessFeedbackSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#kms_master_key_id SnsTopic#kms_master_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsMasterKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#lambda_failure_feedback_role_arn SnsTopic#lambda_failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LambdaFailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#lambda_success_feedback_role_arn SnsTopic#lambda_success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LambdaSuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#lambda_success_feedback_sample_rate SnsTopic#lambda_success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LambdaSuccessFeedbackSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#name SnsTopic#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#name_prefix SnsTopic#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#policy SnsTopic#policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#sqs_failure_feedback_role_arn SnsTopic#sqs_failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqsFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqsFailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#sqs_success_feedback_role_arn SnsTopic#sqs_success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqsSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqsSuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#sqs_success_feedback_sample_rate SnsTopic#sqs_success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqsSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SqsSuccessFeedbackSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#tags SnsTopic#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
