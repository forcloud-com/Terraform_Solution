using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sns
{
    /// <summary>AWS Simple Notification Service.</summary>
    [JsiiInterface(nativeType: typeof(ISnsTopicSubscriptionConfig), fullyQualifiedName: "aws.sns.SnsTopicSubscriptionConfig")]
    public interface ISnsTopicSubscriptionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#endpoint SnsTopicSubscription#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#protocol SnsTopicSubscription#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#topic_arn SnsTopicSubscription#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#confirmation_timeout_in_minutes SnsTopicSubscription#confirmation_timeout_in_minutes}.</summary>
        [JsiiProperty(name: "confirmationTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConfirmationTimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#delivery_policy SnsTopicSubscription#delivery_policy}.</summary>
        [JsiiProperty(name: "deliveryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#endpoint_auto_confirms SnsTopicSubscription#endpoint_auto_confirms}.</summary>
        [JsiiProperty(name: "endpointAutoConfirms", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EndpointAutoConfirms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#filter_policy SnsTopicSubscription#filter_policy}.</summary>
        [JsiiProperty(name: "filterPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FilterPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#raw_message_delivery SnsTopicSubscription#raw_message_delivery}.</summary>
        [JsiiProperty(name: "rawMessageDelivery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RawMessageDelivery
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Notification Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISnsTopicSubscriptionConfig), fullyQualifiedName: "aws.sns.SnsTopicSubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sns.ISnsTopicSubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#endpoint SnsTopicSubscription#endpoint}.</summary>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#protocol SnsTopicSubscription#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#topic_arn SnsTopicSubscription#topic_arn}.</summary>
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#confirmation_timeout_in_minutes SnsTopicSubscription#confirmation_timeout_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "confirmationTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConfirmationTimeoutInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#delivery_policy SnsTopicSubscription#delivery_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#endpoint_auto_confirms SnsTopicSubscription#endpoint_auto_confirms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointAutoConfirms", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EndpointAutoConfirms
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#filter_policy SnsTopicSubscription#filter_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filterPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FilterPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_topic_subscription#raw_message_delivery SnsTopicSubscription#raw_message_delivery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rawMessageDelivery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RawMessageDelivery
            {
                get => GetInstanceProperty<object?>();
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
