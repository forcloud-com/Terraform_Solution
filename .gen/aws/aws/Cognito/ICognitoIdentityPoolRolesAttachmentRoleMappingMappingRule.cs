using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule), fullyQualifiedName: "aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule")]
    public interface ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#claim CognitoIdentityPoolRolesAttachment#claim}.</summary>
        [JsiiProperty(name: "claim", typeJson: "{\"primitive\":\"string\"}")]
        string Claim
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#match_type CognitoIdentityPoolRolesAttachment#match_type}.</summary>
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}")]
        string MatchType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#role_arn CognitoIdentityPoolRolesAttachment#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#value CognitoIdentityPoolRolesAttachment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule), fullyQualifiedName: "aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#claim CognitoIdentityPoolRolesAttachment#claim}.</summary>
            [JsiiProperty(name: "claim", typeJson: "{\"primitive\":\"string\"}")]
            public string Claim
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#match_type CognitoIdentityPoolRolesAttachment#match_type}.</summary>
            [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#role_arn CognitoIdentityPoolRolesAttachment#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#value CognitoIdentityPoolRolesAttachment#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
