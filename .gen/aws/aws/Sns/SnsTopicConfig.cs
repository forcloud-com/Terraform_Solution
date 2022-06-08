using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sns
{
    /// <summary>AWS Simple Notification Service.</summary>
    [JsiiByValue(fqn: "aws.sns.SnsTopicConfig")]
    public class SnsTopicConfig : aws.Sns.ISnsTopicConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#application_failure_feedback_role_arn SnsTopic#application_failure_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationFailureFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#application_success_feedback_role_arn SnsTopic#application_success_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationSuccessFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#application_success_feedback_sample_rate SnsTopic#application_success_feedback_sample_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ApplicationSuccessFeedbackSampleRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#delivery_policy SnsTopic#delivery_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deliveryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeliveryPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#display_name SnsTopic#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#http_failure_feedback_role_arn SnsTopic#http_failure_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpFailureFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#http_success_feedback_role_arn SnsTopic#http_success_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpSuccessFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#http_success_feedback_sample_rate SnsTopic#http_success_feedback_sample_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpSuccessFeedbackSampleRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#kms_master_key_id SnsTopic#kms_master_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsMasterKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#lambda_failure_feedback_role_arn SnsTopic#lambda_failure_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LambdaFailureFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#lambda_success_feedback_role_arn SnsTopic#lambda_success_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LambdaSuccessFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#lambda_success_feedback_sample_rate SnsTopic#lambda_success_feedback_sample_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LambdaSuccessFeedbackSampleRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#name SnsTopic#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#name_prefix SnsTopic#name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#policy SnsTopic#policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Policy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#sqs_failure_feedback_role_arn SnsTopic#sqs_failure_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqsFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SqsFailureFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#sqs_success_feedback_role_arn SnsTopic#sqs_success_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqsSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SqsSuccessFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#sqs_success_feedback_sample_rate SnsTopic#sqs_success_feedback_sample_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqsSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SqsSuccessFeedbackSampleRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic#tags SnsTopic#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
