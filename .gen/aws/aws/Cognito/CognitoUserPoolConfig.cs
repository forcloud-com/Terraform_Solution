using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    /// <summary>AWS Cognito.</summary>
    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolConfig")]
    public class CognitoUserPoolConfig : aws.Cognito.ICognitoUserPoolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#name CognitoUserPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>admin_create_user_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#admin_create_user_config CognitoUserPool#admin_create_user_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolAdminCreateUserConfig? AdminCreateUserConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#alias_attributes CognitoUserPool#alias_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AliasAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#auto_verified_attributes CognitoUserPool#auto_verified_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AutoVerifiedAttributes
        {
            get;
            set;
        }

        /// <summary>device_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#device_configuration CognitoUserPool#device_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolDeviceConfiguration\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolDeviceConfiguration? DeviceConfiguration
        {
            get;
            set;
        }

        /// <summary>email_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_configuration CognitoUserPool#email_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolEmailConfiguration\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolEmailConfiguration? EmailConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_verification_message CognitoUserPool#email_verification_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailVerificationMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_verification_subject CognitoUserPool#email_verification_subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailVerificationSubject
        {
            get;
            set;
        }

        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#lambda_config CognitoUserPool#lambda_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfig\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolLambdaConfig? LambdaConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#mfa_configuration CognitoUserPool#mfa_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MfaConfiguration
        {
            get;
            set;
        }

        /// <summary>password_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#password_policy CognitoUserPool#password_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolPasswordPolicy\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolPasswordPolicy? PasswordPolicy
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#schema CognitoUserPool#schema}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Schema
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_authentication_message CognitoUserPool#sms_authentication_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SmsAuthenticationMessage
        {
            get;
            set;
        }

        /// <summary>sms_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_configuration CognitoUserPool#sms_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smsConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSmsConfiguration\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolSmsConfiguration? SmsConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_verification_message CognitoUserPool#sms_verification_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SmsVerificationMessage
        {
            get;
            set;
        }

        /// <summary>software_token_mfa_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#software_token_mfa_configuration CognitoUserPool#software_token_mfa_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSoftwareTokenMfaConfiguration\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#tags CognitoUserPool#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#username_attributes CognitoUserPool#username_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UsernameAttributes
        {
            get;
            set;
        }

        /// <summary>username_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#username_configuration CognitoUserPool#username_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUsernameConfiguration\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolUsernameConfiguration? UsernameConfiguration
        {
            get;
            set;
        }

        /// <summary>user_pool_add_ons block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#user_pool_add_ons CognitoUserPool#user_pool_add_ons}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUserPoolAddOns\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolUserPoolAddOns? UserPoolAddOns
        {
            get;
            set;
        }

        /// <summary>verification_message_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#verification_message_template CognitoUserPool#verification_message_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolVerificationMessageTemplate\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolVerificationMessageTemplate? VerificationMessageTemplate
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
