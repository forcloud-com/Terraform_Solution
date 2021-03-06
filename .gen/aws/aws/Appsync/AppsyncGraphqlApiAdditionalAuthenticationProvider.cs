using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProvider")]
    public class AppsyncGraphqlApiAdditionalAuthenticationProvider : aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#authentication_type AppsyncGraphqlApi#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticationType
        {
            get;
            set;
        }

        /// <summary>openid_connect_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#openid_connect_config AppsyncGraphqlApi#openid_connect_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig
        {
            get;
            set;
        }

        /// <summary>user_pool_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#user_pool_config AppsyncGraphqlApi#user_pool_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig
        {
            get;
            set;
        }
    }
}
