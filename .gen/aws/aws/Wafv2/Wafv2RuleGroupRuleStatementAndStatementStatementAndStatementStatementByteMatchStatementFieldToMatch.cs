using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatch")]
    public class Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatch : aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#all_query_arguments Wafv2RuleGroup#all_query_arguments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchAllQueryArguments? AllQueryArguments
        {
            get;
            set;
        }

        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#body Wafv2RuleGroup#body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchBody\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchBody? Body
        {
            get;
            set;
        }

        /// <summary>method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#method Wafv2RuleGroup#method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchMethod\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchMethod? Method
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#query_string Wafv2RuleGroup#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchQueryString? QueryString
        {
            get;
            set;
        }

        /// <summary>single_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_header Wafv2RuleGroup#single_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader? SingleHeader
        {
            get;
            set;
        }

        /// <summary>single_query_argument block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_query_argument Wafv2RuleGroup#single_query_argument}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
        {
            get;
            set;
        }

        /// <summary>uri_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#uri_path Wafv2RuleGroup#uri_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatchUriPath? UriPath
        {
            get;
            set;
        }
    }
}
