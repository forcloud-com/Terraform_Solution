using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    /// <summary>AWS Cognito.</summary>
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolConfig), fullyQualifiedName: "aws.cognito.CognitoUserPoolConfig")]
    public interface ICognitoUserPoolConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#name CognitoUserPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>admin_create_user_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#admin_create_user_config CognitoUserPool#admin_create_user_config}
        /// </remarks>
        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolAdminCreateUserConfig? AdminCreateUserConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#alias_attributes CognitoUserPool#alias_attributes}.</summary>
        [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AliasAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#auto_verified_attributes CognitoUserPool#auto_verified_attributes}.</summary>
        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AutoVerifiedAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>device_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#device_configuration CognitoUserPool#device_configuration}
        /// </remarks>
        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolDeviceConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolDeviceConfiguration? DeviceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>email_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_configuration CognitoUserPool#email_configuration}
        /// </remarks>
        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolEmailConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolEmailConfiguration? EmailConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_verification_message CognitoUserPool#email_verification_message}.</summary>
        [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailVerificationMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_verification_subject CognitoUserPool#email_verification_subject}.</summary>
        [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailVerificationSubject
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#lambda_config CognitoUserPool#lambda_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolLambdaConfig? LambdaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#mfa_configuration CognitoUserPool#mfa_configuration}.</summary>
        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MfaConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>password_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#password_policy CognitoUserPool#password_policy}
        /// </remarks>
        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolPasswordPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolPasswordPolicy? PasswordPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#schema CognitoUserPool#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Schema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_authentication_message CognitoUserPool#sms_authentication_message}.</summary>
        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmsAuthenticationMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>sms_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_configuration CognitoUserPool#sms_configuration}
        /// </remarks>
        [JsiiProperty(name: "smsConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSmsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolSmsConfiguration? SmsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_verification_message CognitoUserPool#sms_verification_message}.</summary>
        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmsVerificationMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>software_token_mfa_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#software_token_mfa_configuration CognitoUserPool#software_token_mfa_configuration}
        /// </remarks>
        [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSoftwareTokenMfaConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#tags CognitoUserPool#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#username_attributes CognitoUserPool#username_attributes}.</summary>
        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UsernameAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>username_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#username_configuration CognitoUserPool#username_configuration}
        /// </remarks>
        [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUsernameConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolUsernameConfiguration? UsernameConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_pool_add_ons block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#user_pool_add_ons CognitoUserPool#user_pool_add_ons}
        /// </remarks>
        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUserPoolAddOns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolUserPoolAddOns? UserPoolAddOns
        {
            get
            {
                return null;
            }
        }

        /// <summary>verification_message_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#verification_message_template CognitoUserPool#verification_message_template}
        /// </remarks>
        [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolVerificationMessageTemplate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoUserPoolVerificationMessageTemplate? VerificationMessageTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Cognito.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolConfig), fullyQualifiedName: "aws.cognito.CognitoUserPoolConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#name CognitoUserPool#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>admin_create_user_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#admin_create_user_config CognitoUserPool#admin_create_user_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolAdminCreateUserConfig? AdminCreateUserConfig
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolAdminCreateUserConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#alias_attributes CognitoUserPool#alias_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AliasAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#auto_verified_attributes CognitoUserPool#auto_verified_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AutoVerifiedAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>device_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#device_configuration CognitoUserPool#device_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolDeviceConfiguration\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolDeviceConfiguration? DeviceConfiguration
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolDeviceConfiguration?>();
            }

            /// <summary>email_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_configuration CognitoUserPool#email_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolEmailConfiguration\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolEmailConfiguration? EmailConfiguration
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolEmailConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_verification_message CognitoUserPool#email_verification_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailVerificationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_verification_subject CognitoUserPool#email_verification_subject}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailVerificationSubject
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lambda_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#lambda_config CognitoUserPool#lambda_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfig\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolLambdaConfig? LambdaConfig
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolLambdaConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#mfa_configuration CognitoUserPool#mfa_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MfaConfiguration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>password_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#password_policy CognitoUserPool#password_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolPasswordPolicy\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolPasswordPolicy? PasswordPolicy
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolPasswordPolicy?>();
            }

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#schema CognitoUserPool#schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Schema
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_authentication_message CognitoUserPool#sms_authentication_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmsAuthenticationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>sms_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_configuration CognitoUserPool#sms_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smsConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSmsConfiguration\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolSmsConfiguration? SmsConfiguration
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolSmsConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_verification_message CognitoUserPool#sms_verification_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmsVerificationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>software_token_mfa_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#software_token_mfa_configuration CognitoUserPool#software_token_mfa_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSoftwareTokenMfaConfiguration\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfiguration
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#tags CognitoUserPool#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#username_attributes CognitoUserPool#username_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UsernameAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>username_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#username_configuration CognitoUserPool#username_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUsernameConfiguration\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolUsernameConfiguration? UsernameConfiguration
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolUsernameConfiguration?>();
            }

            /// <summary>user_pool_add_ons block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#user_pool_add_ons CognitoUserPool#user_pool_add_ons}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUserPoolAddOns\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolUserPoolAddOns? UserPoolAddOns
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolUserPoolAddOns?>();
            }

            /// <summary>verification_message_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#verification_message_template CognitoUserPool#verification_message_template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolVerificationMessageTemplate\"}", isOptional: true)]
            public aws.Cognito.ICognitoUserPoolVerificationMessageTemplate? VerificationMessageTemplate
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolVerificationMessageTemplate?>();
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
