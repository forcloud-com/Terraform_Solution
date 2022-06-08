using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sns
{
    /// <summary>AWS Simple Notification Service.</summary>
    [JsiiInterface(nativeType: typeof(ISnsPlatformApplicationConfig), fullyQualifiedName: "aws.sns.SnsPlatformApplicationConfig")]
    public interface ISnsPlatformApplicationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#name SnsPlatformApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#platform SnsPlatformApplication#platform}.</summary>
        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        string Platform
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#platform_credential SnsPlatformApplication#platform_credential}.</summary>
        [JsiiProperty(name: "platformCredential", typeJson: "{\"primitive\":\"string\"}")]
        string PlatformCredential
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_delivery_failure_topic_arn SnsPlatformApplication#event_delivery_failure_topic_arn}.</summary>
        [JsiiProperty(name: "eventDeliveryFailureTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventDeliveryFailureTopicArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_endpoint_created_topic_arn SnsPlatformApplication#event_endpoint_created_topic_arn}.</summary>
        [JsiiProperty(name: "eventEndpointCreatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventEndpointCreatedTopicArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_endpoint_deleted_topic_arn SnsPlatformApplication#event_endpoint_deleted_topic_arn}.</summary>
        [JsiiProperty(name: "eventEndpointDeletedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventEndpointDeletedTopicArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_endpoint_updated_topic_arn SnsPlatformApplication#event_endpoint_updated_topic_arn}.</summary>
        [JsiiProperty(name: "eventEndpointUpdatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventEndpointUpdatedTopicArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#failure_feedback_role_arn SnsPlatformApplication#failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "failureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#platform_principal SnsPlatformApplication#platform_principal}.</summary>
        [JsiiProperty(name: "platformPrincipal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformPrincipal
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#success_feedback_role_arn SnsPlatformApplication#success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "successFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#success_feedback_sample_rate SnsPlatformApplication#success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "successFeedbackSampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Notification Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISnsPlatformApplicationConfig), fullyQualifiedName: "aws.sns.SnsPlatformApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sns.ISnsPlatformApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#name SnsPlatformApplication#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#platform SnsPlatformApplication#platform}.</summary>
            [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
            public string Platform
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#platform_credential SnsPlatformApplication#platform_credential}.</summary>
            [JsiiProperty(name: "platformCredential", typeJson: "{\"primitive\":\"string\"}")]
            public string PlatformCredential
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_delivery_failure_topic_arn SnsPlatformApplication#event_delivery_failure_topic_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventDeliveryFailureTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventDeliveryFailureTopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_endpoint_created_topic_arn SnsPlatformApplication#event_endpoint_created_topic_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventEndpointCreatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventEndpointCreatedTopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_endpoint_deleted_topic_arn SnsPlatformApplication#event_endpoint_deleted_topic_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventEndpointDeletedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventEndpointDeletedTopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#event_endpoint_updated_topic_arn SnsPlatformApplication#event_endpoint_updated_topic_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventEndpointUpdatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventEndpointUpdatedTopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#failure_feedback_role_arn SnsPlatformApplication#failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#platform_principal SnsPlatformApplication#platform_principal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "platformPrincipal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformPrincipal
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#success_feedback_role_arn SnsPlatformApplication#success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "successFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sns_platform_application#success_feedback_sample_rate SnsPlatformApplication#success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "successFeedbackSampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SuccessFeedbackSampleRate
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
