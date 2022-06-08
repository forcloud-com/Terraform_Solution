using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiInterface(nativeType: typeof(IAppsyncGraphqlApiAdditionalAuthenticationProvider), fullyQualifiedName: "aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProvider")]
    public interface IAppsyncGraphqlApiAdditionalAuthenticationProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#authentication_type AppsyncGraphqlApi#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthenticationType
        {
            get;
        }

        /// <summary>openid_connect_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#openid_connect_config AppsyncGraphqlApi#openid_connect_config}
        /// </remarks>
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig
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
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncGraphqlApiAdditionalAuthenticationProvider), fullyQualifiedName: "aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProvider")]
        internal sealed class _Proxy : DeputyBase, aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProvider
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

            /// <summary>openid_connect_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#openid_connect_config AppsyncGraphqlApi#openid_connect_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig?>();
            }

            /// <summary>user_pool_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#user_pool_config AppsyncGraphqlApi#user_pool_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig?>();
            }
        }
    }
}
