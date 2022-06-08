using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatch), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatch")]
    public interface IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#all_query_arguments Wafv2WebAcl#all_query_arguments}
        /// </remarks>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchAllQueryArguments? AllQueryArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#body Wafv2WebAcl#body}
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchBody\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchBody? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#method Wafv2WebAcl#method}
        /// </remarks>
        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchMethod? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#query_string Wafv2WebAcl#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchQueryString? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#single_header Wafv2WebAcl#single_header}
        /// </remarks>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_query_argument block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#single_query_argument Wafv2WebAcl#single_query_argument}
        /// </remarks>
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#uri_path Wafv2WebAcl#uri_path}
        /// </remarks>
        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchUriPath? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatch), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#all_query_arguments Wafv2WebAcl#all_query_arguments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchAllQueryArguments? AllQueryArguments
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchAllQueryArguments?>();
            }

            /// <summary>body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#body Wafv2WebAcl#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchBody\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchBody? Body
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchBody?>();
            }

            /// <summary>method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#method Wafv2WebAcl#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchMethod\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchMethod? Method
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchMethod?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#query_string Wafv2WebAcl#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchQueryString? QueryString
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchQueryString?>();
            }

            /// <summary>single_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#single_header Wafv2WebAcl#single_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader? SingleHeader
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader?>();
            }

            /// <summary>single_query_argument block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#single_query_argument Wafv2WebAcl#single_query_argument}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument?>();
            }

            /// <summary>uri_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#uri_path Wafv2WebAcl#uri_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchUriPath? UriPath
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchUriPath?>();
            }
        }
    }
}
