using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementGeoMatchStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementGeoMatchStatement : aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementGeoMatchStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#country_codes Wafv2WebAcl#country_codes}.</summary>
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CountryCodes
        {
            get;
            set;
        }
    }
}
