using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    #pragma warning disable CS8618

    /// <summary>AWS Simple Email Service.</summary>
    [JsiiByValue(fqn: "aws.ses.SesIdentityNotificationTopicConfig")]
    public class SesIdentityNotificationTopicConfig : aws.Ses.ISesIdentityNotificationTopicConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_identity_notification_topic#identity SesIdentityNotificationTopic#identity}.</summary>
        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}")]
        public string Identity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_identity_notification_topic#notification_type SesIdentityNotificationTopic#notification_type}.</summary>
        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}")]
        public string NotificationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_identity_notification_topic#include_original_headers SesIdentityNotificationTopic#include_original_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeOriginalHeaders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeOriginalHeaders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_identity_notification_topic#topic_arn SesIdentityNotificationTopic#topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TopicArn
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
