using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codestar
{
    #pragma warning disable CS8618

    /// <summary>AWS CodeStar.</summary>
    [JsiiByValue(fqn: "aws.codestar.CodestarnotificationsNotificationRuleConfig")]
    public class CodestarnotificationsNotificationRuleConfig : aws.Codestar.ICodestarnotificationsNotificationRuleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codestarnotifications_notification_rule#detail_type CodestarnotificationsNotificationRule#detail_type}.</summary>
        [JsiiProperty(name: "detailType", typeJson: "{\"primitive\":\"string\"}")]
        public string DetailType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codestarnotifications_notification_rule#event_type_ids CodestarnotificationsNotificationRule#event_type_ids}.</summary>
        [JsiiProperty(name: "eventTypeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] EventTypeIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codestarnotifications_notification_rule#name CodestarnotificationsNotificationRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codestarnotifications_notification_rule#resource CodestarnotificationsNotificationRule#resource}.</summary>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        public string Resource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codestarnotifications_notification_rule#status CodestarnotificationsNotificationRule#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codestarnotifications_notification_rule#tags CodestarnotificationsNotificationRule#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codestarnotifications_notification_rule#target CodestarnotificationsNotificationRule#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codestar.CodestarnotificationsNotificationRuleTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Target
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
