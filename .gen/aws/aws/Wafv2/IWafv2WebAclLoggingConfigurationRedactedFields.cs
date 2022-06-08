using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFields")]
    public interface IWafv2WebAclLoggingConfigurationRedactedFields
    {
        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#all_query_arguments Wafv2WebAclLoggingConfiguration#all_query_arguments}
        /// </remarks>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments? AllQueryArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#body Wafv2WebAclLoggingConfiguration#body}
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsBody\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsBody? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#method Wafv2WebAclLoggingConfiguration#method}
        /// </remarks>
        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsMethod? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#query_string Wafv2WebAclLoggingConfiguration#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsQueryString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsQueryString? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#single_header Wafv2WebAclLoggingConfiguration#single_header}
        /// </remarks>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_query_argument block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#single_query_argument Wafv2WebAclLoggingConfiguration#single_query_argument}
        /// </remarks>
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument? SingleQueryArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#uri_path Wafv2WebAclLoggingConfiguration#uri_path}
        /// </remarks>
        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsUriPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsUriPath? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFields")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#all_query_arguments Wafv2WebAclLoggingConfiguration#all_query_arguments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments? AllQueryArguments
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments?>();
            }

            /// <summary>body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#body Wafv2WebAclLoggingConfiguration#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsBody\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsBody? Body
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsBody?>();
            }

            /// <summary>method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#method Wafv2WebAclLoggingConfiguration#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsMethod\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsMethod? Method
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsMethod?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#query_string Wafv2WebAclLoggingConfiguration#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsQueryString\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsQueryString? QueryString
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsQueryString?>();
            }

            /// <summary>single_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#single_header Wafv2WebAclLoggingConfiguration#single_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader? SingleHeader
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader?>();
            }

            /// <summary>single_query_argument block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#single_query_argument Wafv2WebAclLoggingConfiguration#single_query_argument}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument?>();
            }

            /// <summary>uri_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#uri_path Wafv2WebAclLoggingConfiguration#uri_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsUriPath\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsUriPath? UriPath
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsUriPath?>();
            }
        }
    }
}
