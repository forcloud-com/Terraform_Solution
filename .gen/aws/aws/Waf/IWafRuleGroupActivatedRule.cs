using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafRuleGroupActivatedRule), fullyQualifiedName: "aws.waf.WafRuleGroupActivatedRule")]
    public interface IWafRuleGroupActivatedRule
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#action WafRuleGroup#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.waf.WafRuleGroupActivatedRuleAction\"}")]
        aws.Waf.IWafRuleGroupActivatedRuleAction Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#priority WafRuleGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#rule_id WafRuleGroup#rule_id}.</summary>
        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        string RuleId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#type WafRuleGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafRuleGroupActivatedRule), fullyQualifiedName: "aws.waf.WafRuleGroupActivatedRule")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafRuleGroupActivatedRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#action WafRuleGroup#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.waf.WafRuleGroupActivatedRuleAction\"}")]
            public aws.Waf.IWafRuleGroupActivatedRuleAction Action
            {
                get => GetInstanceProperty<aws.Waf.IWafRuleGroupActivatedRuleAction>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#priority WafRuleGroup#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#rule_id WafRuleGroup#rule_id}.</summary>
            [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#type WafRuleGroup#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
