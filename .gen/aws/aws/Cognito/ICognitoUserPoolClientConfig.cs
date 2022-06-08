using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    /// <summary>AWS Cognito.</summary>
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolClientConfig), fullyQualifiedName: "aws.cognito.CognitoUserPoolClientConfig")]
    public interface ICognitoUserPoolClientConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#name CognitoUserPoolClient#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#user_pool_id CognitoUserPoolClient#user_pool_id}.</summary>
        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#allowed_oauth_flows CognitoUserPoolClient#allowed_oauth_flows}.</summary>
        [JsiiProperty(name: "allowedOauthFlows", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedOauthFlows
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#allowed_oauth_flows_user_pool_client CognitoUserPoolClient#allowed_oauth_flows_user_pool_client}.</summary>
        [JsiiProperty(name: "allowedOauthFlowsUserPoolClient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowedOauthFlowsUserPoolClient
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#allowed_oauth_scopes CognitoUserPoolClient#allowed_oauth_scopes}.</summary>
        [JsiiProperty(name: "allowedOauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedOauthScopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>analytics_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#analytics_configuration CognitoUserPoolClient#analytics_configuration}
        /// </remarks>
        [JsiiProperty(name: "analyticsConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolClientAnalyticsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolClientAnalyticsConfiguration? AnalyticsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#callback_urls CognitoUserPoolClient#callback_urls}.</summary>
        [JsiiProperty(name: "callbackUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CallbackUrls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#default_redirect_uri CognitoUserPoolClient#default_redirect_uri}.</summary>
        [JsiiProperty(name: "defaultRedirectUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultRedirectUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#explicit_auth_flows CognitoUserPoolClient#explicit_auth_flows}.</summary>
        [JsiiProperty(name: "explicitAuthFlows", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExplicitAuthFlows
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#generate_secret CognitoUserPoolClient#generate_secret}.</summary>
        [JsiiProperty(name: "generateSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GenerateSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#logout_urls CognitoUserPoolClient#logout_urls}.</summary>
        [JsiiProperty(name: "logoutUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LogoutUrls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#prevent_user_existence_errors CognitoUserPoolClient#prevent_user_existence_errors}.</summary>
        [JsiiProperty(name: "preventUserExistenceErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreventUserExistenceErrors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#read_attributes CognitoUserPoolClient#read_attributes}.</summary>
        [JsiiProperty(name: "readAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ReadAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#refresh_token_validity CognitoUserPoolClient#refresh_token_validity}.</summary>
        [JsiiProperty(name: "refreshTokenValidity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RefreshTokenValidity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#supported_identity_providers CognitoUserPoolClient#supported_identity_providers}.</summary>
        [JsiiProperty(name: "supportedIdentityProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SupportedIdentityProviders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#write_attributes CognitoUserPoolClient#write_attributes}.</summary>
        [JsiiProperty(name: "writeAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WriteAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Cognito.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolClientConfig), fullyQualifiedName: "aws.cognito.CognitoUserPoolClientConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolClientConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#name CognitoUserPoolClient#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#user_pool_id CognitoUserPoolClient#user_pool_id}.</summary>
            [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#allowed_oauth_flows CognitoUserPoolClient#allowed_oauth_flows}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedOauthFlows", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedOauthFlows
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#allowed_oauth_flows_user_pool_client CognitoUserPoolClient#allowed_oauth_flows_user_pool_client}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedOauthFlowsUserPoolClient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowedOauthFlowsUserPoolClient
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#allowed_oauth_scopes CognitoUserPoolClient#allowed_oauth_scopes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedOauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedOauthScopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>analytics_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#analytics_configuration CognitoUserPoolClient#analytics_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "analyticsConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolClientAnalyticsConfiguration\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolClientAnalyticsConfiguration? AnalyticsConfiguration
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolClientAnalyticsConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#callback_urls CognitoUserPoolClient#callback_urls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "callbackUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CallbackUrls
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#default_redirect_uri CognitoUserPoolClient#default_redirect_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRedirectUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultRedirectUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#explicit_auth_flows CognitoUserPoolClient#explicit_auth_flows}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "explicitAuthFlows", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExplicitAuthFlows
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#generate_secret CognitoUserPoolClient#generate_secret}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? GenerateSecret
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#logout_urls CognitoUserPoolClient#logout_urls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LogoutUrls
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#prevent_user_existence_errors CognitoUserPoolClient#prevent_user_existence_errors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preventUserExistenceErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreventUserExistenceErrors
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#read_attributes CognitoUserPoolClient#read_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ReadAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#refresh_token_validity CognitoUserPoolClient#refresh_token_validity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshTokenValidity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RefreshTokenValidity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#supported_identity_providers CognitoUserPoolClient#supported_identity_providers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "supportedIdentityProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SupportedIdentityProviders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#write_attributes CognitoUserPoolClient#write_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "writeAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WriteAttributes
            {
                get => GetInstanceProperty<string[]?>();
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
