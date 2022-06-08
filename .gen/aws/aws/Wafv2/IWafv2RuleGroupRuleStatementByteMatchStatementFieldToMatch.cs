using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatch), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatch")]
    public interface IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#all_query_arguments Wafv2RuleGroup#all_query_arguments}
        /// </remarks>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchAllQueryArguments? AllQueryArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#body Wafv2RuleGroup#body}
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchBody\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchBody? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#method Wafv2RuleGroup#method}
        /// </remarks>
        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchMethod? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#query_string Wafv2RuleGroup#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchQueryString? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_header Wafv2RuleGroup#single_header}
        /// </remarks>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleHeader? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_query_argument block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_query_argument Wafv2RuleGroup#single_query_argument}
        /// </remarks>
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#uri_path Wafv2RuleGroup#uri_path}
        /// </remarks>
        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchUriPath? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatch), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#all_query_arguments Wafv2RuleGroup#all_query_arguments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchAllQueryArguments? AllQueryArguments
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchAllQueryArguments?>();
            }

            /// <summary>body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#body Wafv2RuleGroup#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchBody\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchBody? Body
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchBody?>();
            }

            /// <summary>method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#method Wafv2RuleGroup#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchMethod\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchMethod? Method
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchMethod?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#query_string Wafv2RuleGroup#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchQueryString? QueryString
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchQueryString?>();
            }

            /// <summary>single_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_header Wafv2RuleGroup#single_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleHeader? SingleHeader
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleHeader?>();
            }

            /// <summary>single_query_argument block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_query_argument Wafv2RuleGroup#single_query_argument}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchSingleQueryArgument?>();
            }

            /// <summary>uri_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#uri_path Wafv2RuleGroup#uri_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchUriPath? UriPath
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatementFieldToMatchUriPath?>();
            }
        }
    }
}
