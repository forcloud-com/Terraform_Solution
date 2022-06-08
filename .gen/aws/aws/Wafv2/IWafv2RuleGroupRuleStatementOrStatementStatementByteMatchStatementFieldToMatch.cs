using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatch), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatch")]
    public interface IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#all_query_arguments Wafv2RuleGroup#all_query_arguments}
        /// </remarks>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments? AllQueryArguments
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
        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody? Body
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
        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod? Method
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
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString? QueryString
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
        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader? SingleHeader
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
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
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
        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatch), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#all_query_arguments Wafv2RuleGroup#all_query_arguments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments? AllQueryArguments
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments?>();
            }

            /// <summary>body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#body Wafv2RuleGroup#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody? Body
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody?>();
            }

            /// <summary>method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#method Wafv2RuleGroup#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod? Method
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#query_string Wafv2RuleGroup#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString? QueryString
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString?>();
            }

            /// <summary>single_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_header Wafv2RuleGroup#single_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader? SingleHeader
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader?>();
            }

            /// <summary>single_query_argument block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_query_argument Wafv2RuleGroup#single_query_argument}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument?>();
            }

            /// <summary>uri_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#uri_path Wafv2RuleGroup#uri_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath? UriPath
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath?>();
            }
        }
    }
}
