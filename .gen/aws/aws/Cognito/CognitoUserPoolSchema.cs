using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolSchema")]
    public class CognitoUserPoolSchema : aws.Cognito.ICognitoUserPoolSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#attribute_data_type CognitoUserPool#attribute_data_type}.</summary>
        [JsiiProperty(name: "attributeDataType", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeDataType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#name CognitoUserPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#developer_only_attribute CognitoUserPool#developer_only_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "developerOnlyAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeveloperOnlyAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#mutable CognitoUserPool#mutable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mutable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Mutable
        {
            get;
            set;
        }

        /// <summary>number_attribute_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#number_attribute_constraints CognitoUserPool#number_attribute_constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSchemaNumberAttributeConstraints\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolSchemaNumberAttributeConstraints? NumberAttributeConstraints
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#required CognitoUserPool#required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Required
        {
            get;
            set;
        }

        /// <summary>string_attribute_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#string_attribute_constraints CognitoUserPool#string_attribute_constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSchemaStringAttributeConstraints\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolSchemaStringAttributeConstraints? StringAttributeConstraints
        {
            get;
            set;
        }
    }
}
