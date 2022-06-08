using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    /// <summary>AWS AppSync.</summary>
    [JsiiInterface(nativeType: typeof(IAppsyncGraphqlApiConfig), fullyQualifiedName: "aws.appsync.AppsyncGraphqlApiConfig")]
    public interface IAppsyncGraphqlApiConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#authentication_type AppsyncGraphqlApi#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthenticationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#name AppsyncGraphqlApi#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>additional_authentication_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#additional_authentication_provider AppsyncGraphqlApi#additional_authentication_provider}
        /// </remarks>
        [JsiiProperty(name: "additionalAuthenticationProvider", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalAuthenticationProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#log_config AppsyncGraphqlApi#log_config}
        /// </remarks>
        [JsiiProperty(name: "logConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiLogConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncGraphqlApiLogConfig? LogConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>openid_connect_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#openid_connect_config AppsyncGraphqlApi#openid_connect_config}
        /// </remarks>
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiOpenidConnectConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig? OpenidConnectConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#schema AppsyncGraphqlApi#schema}.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Schema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#tags AppsyncGraphqlApi#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_pool_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#user_pool_config AppsyncGraphqlApi#user_pool_config}
        /// </remarks>
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiUserPoolConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncGraphqlApiUserPoolConfig? UserPoolConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#xray_enabled AppsyncGraphqlApi#xray_enabled}.</summary>
        [JsiiProperty(name: "xrayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? XrayEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS AppSync.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAppsyncGraphqlApiConfig), fullyQualifiedName: "aws.appsync.AppsyncGraphqlApiConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appsync.IAppsyncGraphqlApiConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#authentication_type AppsyncGraphqlApi#authentication_type}.</summary>
            [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthenticationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#name AppsyncGraphqlApi#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_authentication_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#additional_authentication_provider AppsyncGraphqlApi#additional_authentication_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalAuthenticationProvider", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalAuthenticationProvider
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>log_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#log_config AppsyncGraphqlApi#log_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiLogConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncGraphqlApiLogConfig? LogConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiLogConfig?>();
            }

            /// <summary>openid_connect_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#openid_connect_config AppsyncGraphqlApi#openid_connect_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiOpenidConnectConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig? OpenidConnectConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#schema AppsyncGraphqlApi#schema}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Schema
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#tags AppsyncGraphqlApi#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>user_pool_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#user_pool_config AppsyncGraphqlApi#user_pool_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiUserPoolConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncGraphqlApiUserPoolConfig? UserPoolConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiUserPoolConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#xray_enabled AppsyncGraphqlApi#xray_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xrayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? XrayEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
