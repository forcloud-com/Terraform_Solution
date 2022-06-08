using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatch), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatch")]
    public interface IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#all_query_arguments Wafv2RuleGroup#all_query_arguments}
        /// </remarks>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchAllQueryArguments? AllQueryArguments
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
        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchBody\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchBody? Body
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
        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchMethod? Method
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
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchQueryString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchQueryString? QueryString
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
        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleHeader? SingleHeader
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
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
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
        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchUriPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchUriPath? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatch), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#all_query_arguments Wafv2RuleGroup#all_query_arguments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchAllQueryArguments? AllQueryArguments
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchAllQueryArguments?>();
            }

            /// <summary>body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#body Wafv2RuleGroup#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchBody\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchBody? Body
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchBody?>();
            }

            /// <summary>method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#method Wafv2RuleGroup#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchMethod\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchMethod? Method
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchMethod?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#query_string Wafv2RuleGroup#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchQueryString\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchQueryString? QueryString
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchQueryString?>();
            }

            /// <summary>single_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_header Wafv2RuleGroup#single_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleHeader\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleHeader? SingleHeader
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleHeader?>();
            }

            /// <summary>single_query_argument block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#single_query_argument Wafv2RuleGroup#single_query_argument}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument?>();
            }

            /// <summary>uri_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#uri_path Wafv2RuleGroup#uri_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchUriPath\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchUriPath? UriPath
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatementFieldToMatchUriPath?>();
            }
        }
    }
}
