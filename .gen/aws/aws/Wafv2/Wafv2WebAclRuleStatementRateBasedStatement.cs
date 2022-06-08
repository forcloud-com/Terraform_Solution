using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatement : aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#limit Wafv2WebAcl#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public double Limit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#aggregate_key_type Wafv2WebAcl#aggregate_key_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aggregateKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AggregateKeyType
        {
            get;
            set;
        }

        /// <summary>scope_down_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#scope_down_statement Wafv2WebAcl#scope_down_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement? ScopeDownStatement
        {
            get;
            set;
        }
    }
}
