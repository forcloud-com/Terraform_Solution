using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementOrStatement")]
    public class Wafv2RuleGroupRuleStatementOrStatementStatementOrStatement : aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#statement Wafv2RuleGroup#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}]}}")]
        public object Statement
        {
            get;
            set;
        }
    }
}
