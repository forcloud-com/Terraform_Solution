using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    /// <summary>AWS Simple Email Service.</summary>
    [JsiiInterface(nativeType: typeof(ISesActiveReceiptRuleSetConfig), fullyQualifiedName: "aws.ses.SesActiveReceiptRuleSetConfig")]
    public interface ISesActiveReceiptRuleSetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_active_receipt_rule_set#rule_set_name SesActiveReceiptRuleSet#rule_set_name}.</summary>
        [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}")]
        string RuleSetName
        {
            get;
        }

        /// <summary>AWS Simple Email Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISesActiveReceiptRuleSetConfig), fullyQualifiedName: "aws.ses.SesActiveReceiptRuleSetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesActiveReceiptRuleSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_active_receipt_rule_set#rule_set_name SesActiveReceiptRuleSet#rule_set_name}.</summary>
            [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleSetName
            {
                get => GetInstanceProperty<string>()!;
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
