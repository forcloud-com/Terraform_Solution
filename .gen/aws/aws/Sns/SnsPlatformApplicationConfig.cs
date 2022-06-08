using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sns
{
    #pragma warning disable CS8618

    /// <summary>AWS Simple Notification Service.</summary>
    [JsiiByValue(fqn: "aws.sns.SnsPlatformApplicationConfig")]
    public class SnsPlatformApplicationConfig : aws.Sns.ISnsPlatformApplicationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#name SnsPlatformApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#platform SnsPlatformApplication#platform}.</summary>
        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public string Platform
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#platform_credential SnsPlatformApplication#platform_credential}.</summary>
        [JsiiProperty(name: "platformCredential", typeJson: "{\"primitive\":\"string\"}")]
        public string PlatformCredential
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_delivery_failure_topic_arn SnsPlatformApplication#event_delivery_failure_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventDeliveryFailureTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventDeliveryFailureTopicArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_endpoint_created_topic_arn SnsPlatformApplication#event_endpoint_created_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventEndpointCreatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventEndpointCreatedTopicArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_endpoint_deleted_topic_arn SnsPlatformApplication#event_endpoint_deleted_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventEndpointDeletedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventEndpointDeletedTopicArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_endpoint_updated_topic_arn SnsPlatformApplication#event_endpoint_updated_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventEndpointUpdatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventEndpointUpdatedTopicArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#failure_feedback_role_arn SnsPlatformApplication#failure_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailureFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#platform_principal SnsPlatformApplication#platform_principal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platformPrincipal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlatformPrincipal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#success_feedback_role_arn SnsPlatformApplication#success_feedback_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "successFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SuccessFeedbackRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#success_feedback_sample_rate SnsPlatformApplication#success_feedback_sample_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "successFeedbackSampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SuccessFeedbackSampleRate
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
