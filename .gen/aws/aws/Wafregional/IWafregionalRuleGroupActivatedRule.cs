using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalRuleGroupActivatedRule), fullyQualifiedName: "aws.wafregional.WafregionalRuleGroupActivatedRule")]
    public interface IWafregionalRuleGroupActivatedRule
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#action WafregionalRuleGroup#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalRuleGroupActivatedRuleAction\"}")]
        aws.Wafregional.IWafregionalRuleGroupActivatedRuleAction Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#priority WafregionalRuleGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#rule_id WafregionalRuleGroup#rule_id}.</summary>
        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        string RuleId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#type WafregionalRuleGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalRuleGroupActivatedRule), fullyQualifiedName: "aws.wafregional.WafregionalRuleGroupActivatedRule")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalRuleGroupActivatedRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#action WafregionalRuleGroup#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalRuleGroupActivatedRuleAction\"}")]
            public aws.Wafregional.IWafregionalRuleGroupActivatedRuleAction Action
            {
                get => GetInstanceProperty<aws.Wafregional.IWafregionalRuleGroupActivatedRuleAction>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#priority WafregionalRuleGroup#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#rule_id WafregionalRuleGroup#rule_id}.</summary>
            [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#type WafregionalRuleGroup#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
