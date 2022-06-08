using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    #pragma warning disable CS8618

    /// <summary>AWS Simple Email Service.</summary>
    [JsiiByValue(fqn: "aws.ses.SesReceiptRuleConfig")]
    public class SesReceiptRuleConfig : aws.Ses.ISesReceiptRuleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#name SesReceiptRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#rule_set_name SesReceiptRule#rule_set_name}.</summary>
        [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleSetName
        {
            get;
            set;
        }

        /// <summary>add_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#add_header_action SesReceiptRule#add_header_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AddHeaderAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#after SesReceiptRule#after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? After
        {
            get;
            set;
        }

        /// <summary>bounce_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#bounce_action SesReceiptRule#bounce_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bounceAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BounceAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#enabled SesReceiptRule#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>lambda_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#lambda_action SesReceiptRule#lambda_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#recipients SesReceiptRule#recipients}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Recipients
        {
            get;
            set;
        }

        /// <summary>s3_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#s3_action SesReceiptRule#s3_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#scan_enabled SesReceiptRule#scan_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ScanEnabled
        {
            get;
            set;
        }

        /// <summary>sns_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#sns_action SesReceiptRule#sns_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snsAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SnsAction
        {
            get;
            set;
        }

        /// <summary>stop_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#stop_action SesReceiptRule#stop_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stopAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StopAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#tls_policy SesReceiptRule#tls_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsPolicy
        {
            get;
            set;
        }

        /// <summary>workmail_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#workmail_action SesReceiptRule#workmail_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workmailAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WorkmailAction
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
