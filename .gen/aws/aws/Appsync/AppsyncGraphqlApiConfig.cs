using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    /// <summary>AWS AppSync.</summary>
    [JsiiByValue(fqn: "aws.appsync.AppsyncGraphqlApiConfig")]
    public class AppsyncGraphqlApiConfig : aws.Appsync.IAppsyncGraphqlApiConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#authentication_type AppsyncGraphqlApi#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#name AppsyncGraphqlApi#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>additional_authentication_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#additional_authentication_provider AppsyncGraphqlApi#additional_authentication_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalAuthenticationProvider", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalAuthenticationProvider
        {
            get;
            set;
        }

        /// <summary>log_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#log_config AppsyncGraphqlApi#log_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiLogConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncGraphqlApiLogConfig? LogConfig
        {
            get;
            set;
        }

        /// <summary>openid_connect_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#openid_connect_config AppsyncGraphqlApi#openid_connect_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiOpenidConnectConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig? OpenidConnectConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#schema AppsyncGraphqlApi#schema}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Schema
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#tags AppsyncGraphqlApi#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>user_pool_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#user_pool_config AppsyncGraphqlApi#user_pool_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiUserPoolConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncGraphqlApiUserPoolConfig? UserPoolConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#xray_enabled AppsyncGraphqlApi#xray_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "xrayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? XrayEnabled
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
