using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sns
{
    #pragma warning disable CS8618

    /// <summary>AWS Simple Notification Service.</summary>
    [JsiiByValue(fqn: "aws.sns.SnsTopicSubscriptionConfig")]
    public class SnsTopicSubscriptionConfig : aws.Sns.ISnsTopicSubscriptionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#endpoint SnsTopicSubscription#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#protocol SnsTopicSubscription#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#topic_arn SnsTopicSubscription#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#confirmation_timeout_in_minutes SnsTopicSubscription#confirmation_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "confirmationTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConfirmationTimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#delivery_policy SnsTopicSubscription#delivery_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deliveryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeliveryPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#endpoint_auto_confirms SnsTopicSubscription#endpoint_auto_confirms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointAutoConfirms", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EndpointAutoConfirms
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#filter_policy SnsTopicSubscription#filter_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filterPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilterPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#raw_message_delivery SnsTopicSubscription#raw_message_delivery}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rawMessageDelivery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RawMessageDelivery
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
