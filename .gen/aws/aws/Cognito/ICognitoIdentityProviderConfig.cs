using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    /// <summary>AWS Cognito.</summary>
    [JsiiInterface(nativeType: typeof(ICognitoIdentityProviderConfig), fullyQualifiedName: "aws.cognito.CognitoIdentityProviderConfig")]
    public interface ICognitoIdentityProviderConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#provider_details CognitoIdentityProvider#provider_details}.</summary>
        [JsiiProperty(name: "providerDetails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> ProviderDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#provider_name CognitoIdentityProvider#provider_name}.</summary>
        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#provider_type CognitoIdentityProvider#provider_type}.</summary>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#user_pool_id CognitoIdentityProvider#user_pool_id}.</summary>
        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#attribute_mapping CognitoIdentityProvider#attribute_mapping}.</summary>
        [JsiiProperty(name: "attributeMapping", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AttributeMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#idp_identifiers CognitoIdentityProvider#idp_identifiers}.</summary>
        [JsiiProperty(name: "idpIdentifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IdpIdentifiers
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Cognito.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICognitoIdentityProviderConfig), fullyQualifiedName: "aws.cognito.CognitoIdentityProviderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoIdentityProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#provider_details CognitoIdentityProvider#provider_details}.</summary>
            [JsiiProperty(name: "providerDetails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> ProviderDetails
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#provider_name CognitoIdentityProvider#provider_name}.</summary>
            [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#provider_type CognitoIdentityProvider#provider_type}.</summary>
            [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#user_pool_id CognitoIdentityProvider#user_pool_id}.</summary>
            [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#attribute_mapping CognitoIdentityProvider#attribute_mapping}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeMapping", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AttributeMapping
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_provider#idp_identifiers CognitoIdentityProvider#idp_identifiers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idpIdentifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdpIdentifiers
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
