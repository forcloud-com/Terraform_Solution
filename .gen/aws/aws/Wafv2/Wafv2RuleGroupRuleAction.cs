using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleAction")]
    public class Wafv2RuleGroupRuleAction : aws.Wafv2.IWafv2RuleGroupRuleAction
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#allow Wafv2RuleGroup#allow}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllow\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleActionAllow? Allow
        {
            get;
            set;
        }

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#block Wafv2RuleGroup#block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlock\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleActionBlock? Block
        {
            get;
            set;
        }

        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#count Wafv2RuleGroup#count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionCount\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleActionCount? Count
        {
            get;
            set;
        }
    }
}
