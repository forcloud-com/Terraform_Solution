using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSchema), fullyQualifiedName: "aws.cognito.CognitoUserPoolSchema")]
    public interface ICognitoUserPoolSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#attribute_data_type CognitoUserPool#attribute_data_type}.</summary>
        [JsiiProperty(name: "attributeDataType", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeDataType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#name CognitoUserPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#developer_only_attribute CognitoUserPool#developer_only_attribute}.</summary>
        [JsiiProperty(name: "developerOnlyAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeveloperOnlyAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#mutable CognitoUserPool#mutable}.</summary>
        [JsiiProperty(name: "mutable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Mutable
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_attribute_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#number_attribute_constraints CognitoUserPool#number_attribute_constraints}
        /// </remarks>
        [JsiiProperty(name: "numberAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSchemaNumberAttributeConstraints\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolSchemaNumberAttributeConstraints? NumberAttributeConstraints
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#required CognitoUserPool#required}.</summary>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Required
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_attribute_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#string_attribute_constraints CognitoUserPool#string_attribute_constraints}
        /// </remarks>
        [JsiiProperty(name: "stringAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSchemaStringAttributeConstraints\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolSchemaStringAttributeConstraints? StringAttributeConstraints
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSchema), fullyQualifiedName: "aws.cognito.CognitoUserPoolSchema")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#attribute_data_type CognitoUserPool#attribute_data_type}.</summary>
            [JsiiProperty(name: "attributeDataType", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeDataType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#name CognitoUserPool#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#developer_only_attribute CognitoUserPool#developer_only_attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "developerOnlyAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DeveloperOnlyAttribute
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#mutable CognitoUserPool#mutable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mutable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Mutable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_attribute_constraints block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#number_attribute_constraints CognitoUserPool#number_attribute_constraints}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSchemaNumberAttributeConstraints\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolSchemaNumberAttributeConstraints? NumberAttributeConstraints
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolSchemaNumberAttributeConstraints?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#required CognitoUserPool#required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Required
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_attribute_constraints block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#string_attribute_constraints CognitoUserPool#string_attribute_constraints}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSchemaStringAttributeConstraints\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolSchemaStringAttributeConstraints? StringAttributeConstraints
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolSchemaStringAttributeConstraints?>();
            }
        }
    }
}
