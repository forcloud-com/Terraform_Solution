using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatch")]
    public class Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatch : aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#all_query_arguments Wafv2WebAcl#all_query_arguments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments? AllQueryArguments
        {
            get;
            set;
        }

        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#body Wafv2WebAcl#body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchBody\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchBody? Body
        {
            get;
            set;
        }

        /// <summary>method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#method Wafv2WebAcl#method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchMethod\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchMethod? Method
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#query_string Wafv2WebAcl#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchQueryString? QueryString
        {
            get;
            set;
        }

        /// <summary>single_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#single_header Wafv2WebAcl#single_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleHeader? SingleHeader
        {
            get;
            set;
        }

        /// <summary>single_query_argument block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#single_query_argument Wafv2WebAcl#single_query_argument}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
        {
            get;
            set;
        }

        /// <summary>uri_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#uri_path Wafv2WebAcl#uri_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatementFieldToMatchUriPath? UriPath
        {
            get;
            set;
        }
    }
}
