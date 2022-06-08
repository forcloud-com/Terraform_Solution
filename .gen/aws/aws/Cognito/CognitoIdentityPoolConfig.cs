using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    /// <summary>AWS Cognito.</summary>
    [JsiiByValue(fqn: "aws.cognito.CognitoIdentityPoolConfig")]
    public class CognitoIdentityPoolConfig : aws.Cognito.ICognitoIdentityPoolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#identity_pool_name CognitoIdentityPool#identity_pool_name}.</summary>
        [JsiiProperty(name: "identityPoolName", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityPoolName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#allow_unauthenticated_identities CognitoIdentityPool#allow_unauthenticated_identities}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowUnauthenticatedIdentities", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowUnauthenticatedIdentities
        {
            get;
            set;
        }

        /// <summary>cognito_identity_providers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#cognito_identity_providers CognitoIdentityPool#cognito_identity_providers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoIdentityProviders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoIdentityPoolCognitoIdentityProviders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CognitoIdentityProviders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#developer_provider_name CognitoIdentityPool#developer_provider_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "developerProviderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeveloperProviderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#openid_connect_provider_arns CognitoIdentityPool#openid_connect_provider_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "openidConnectProviderArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OpenidConnectProviderArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#saml_provider_arns CognitoIdentityPool#saml_provider_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "samlProviderArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SamlProviderArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#supported_login_providers CognitoIdentityPool#supported_login_providers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "supportedLoginProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SupportedLoginProviders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#tags CognitoIdentityPool#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
