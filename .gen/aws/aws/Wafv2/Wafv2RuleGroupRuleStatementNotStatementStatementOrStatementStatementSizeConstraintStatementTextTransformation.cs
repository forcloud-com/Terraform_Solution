using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementSizeConstraintStatementTextTransformation")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementSizeConstraintStatementTextTransformation : aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementSizeConstraintStatementTextTransformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#priority Wafv2RuleGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#type Wafv2RuleGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
