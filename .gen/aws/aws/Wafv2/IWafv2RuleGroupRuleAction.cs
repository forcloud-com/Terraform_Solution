using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleAction), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleAction")]
    public interface IWafv2RuleGroupRuleAction
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#allow Wafv2RuleGroup#allow}
        /// </remarks>
        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleActionAllow? Allow
        {
            get
            {
                return null;
            }
        }

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#block Wafv2RuleGroup#block}
        /// </remarks>
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleActionBlock? Block
        {
            get
            {
                return null;
            }
        }

        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#count Wafv2RuleGroup#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleActionCount? Count
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleAction), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allow block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#allow Wafv2RuleGroup#allow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllow\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleActionAllow? Allow
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionAllow?>();
            }

            /// <summary>block block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#block Wafv2RuleGroup#block}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlock\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleActionBlock? Block
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionBlock?>();
            }

            /// <summary>count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#count Wafv2RuleGroup#count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionCount\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleActionCount? Count
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionCount?>();
            }
        }
    }
}
