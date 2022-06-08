using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMapping")]
    public class CognitoIdentityPoolRolesAttachmentRoleMapping : aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#identity_provider CognitoIdentityPoolRolesAttachment#identity_provider}.</summary>
        [JsiiProperty(name: "identityProvider", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityProvider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#type CognitoIdentityPoolRolesAttachment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#ambiguous_role_resolution CognitoIdentityPoolRolesAttachment#ambiguous_role_resolution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ambiguousRoleResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmbiguousRoleResolution
        {
            get;
            set;
        }

        /// <summary>mapping_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#mapping_rule CognitoIdentityPoolRolesAttachment#mapping_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mappingRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MappingRule
        {
            get;
            set;
        }
    }
}
