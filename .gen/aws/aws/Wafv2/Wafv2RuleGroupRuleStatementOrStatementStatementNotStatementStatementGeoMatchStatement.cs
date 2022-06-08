using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementGeoMatchStatement")]
    public class Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementGeoMatchStatement : aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementGeoMatchStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#country_codes Wafv2RuleGroup#country_codes}.</summary>
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CountryCodes
        {
            get;
            set;
        }
    }
}
