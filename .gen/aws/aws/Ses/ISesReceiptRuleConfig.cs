using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    /// <summary>AWS Simple Email Service.</summary>
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleConfig), fullyQualifiedName: "aws.ses.SesReceiptRuleConfig")]
    public interface ISesReceiptRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#name SesReceiptRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#rule_set_name SesReceiptRule#rule_set_name}.</summary>
        [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}")]
        string RuleSetName
        {
            get;
        }

        /// <summary>add_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#add_header_action SesReceiptRule#add_header_action}
        /// </remarks>
        [JsiiProperty(name: "addHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AddHeaderAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#after SesReceiptRule#after}.</summary>
        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? After
        {
            get
            {
                return null;
            }
        }

        /// <summary>bounce_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#bounce_action SesReceiptRule#bounce_action}
        /// </remarks>
        [JsiiProperty(name: "bounceAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BounceAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#enabled SesReceiptRule#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#lambda_action SesReceiptRule#lambda_action}
        /// </remarks>
        [JsiiProperty(name: "lambdaAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#recipients SesReceiptRule#recipients}.</summary>
        [JsiiProperty(name: "recipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Recipients
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#s3_action SesReceiptRule#s3_action}
        /// </remarks>
        [JsiiProperty(name: "s3Action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#scan_enabled SesReceiptRule#scan_enabled}.</summary>
        [JsiiProperty(name: "scanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScanEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>sns_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#sns_action SesReceiptRule#sns_action}
        /// </remarks>
        [JsiiProperty(name: "snsAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SnsAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>stop_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#stop_action SesReceiptRule#stop_action}
        /// </remarks>
        [JsiiProperty(name: "stopAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StopAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#tls_policy SesReceiptRule#tls_policy}.</summary>
        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>workmail_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#workmail_action SesReceiptRule#workmail_action}
        /// </remarks>
        [JsiiProperty(name: "workmailAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WorkmailAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Email Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleConfig), fullyQualifiedName: "aws.ses.SesReceiptRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesReceiptRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#name SesReceiptRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#rule_set_name SesReceiptRule#rule_set_name}.</summary>
            [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleSetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>add_header_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#add_header_action SesReceiptRule#add_header_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AddHeaderAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#after SesReceiptRule#after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? After
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>bounce_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#bounce_action SesReceiptRule#bounce_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bounceAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BounceAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#enabled SesReceiptRule#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lambda_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#lambda_action SesReceiptRule#lambda_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#recipients SesReceiptRule#recipients}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Recipients
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>s3_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#s3_action SesReceiptRule#s3_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3Action
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#scan_enabled SesReceiptRule#scan_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ScanEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sns_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#sns_action SesReceiptRule#sns_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snsAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SnsAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>stop_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#stop_action SesReceiptRule#stop_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stopAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StopAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#tls_policy SesReceiptRule#tls_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>workmail_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#workmail_action SesReceiptRule#workmail_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workmailAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WorkmailAction
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
