using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool aws_cognito_user_pool}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cognito.CognitoUserPool), fullyQualifiedName: "aws.cognito.CognitoUserPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolConfig\"}}]")]
    public class CognitoUserPool : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool aws_cognito_user_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CognitoUserPool(Constructs.Construct scope, string id, aws.Cognito.ICognitoUserPoolConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPool(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdminCreateUserConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfig\"}}]")]
        public virtual void PutAdminCreateUserConfig(aws.Cognito.ICognitoUserPoolAdminCreateUserConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolAdminCreateUserConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeviceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolDeviceConfiguration\"}}]")]
        public virtual void PutDeviceConfiguration(aws.Cognito.ICognitoUserPoolDeviceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolDeviceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolEmailConfiguration\"}}]")]
        public virtual void PutEmailConfiguration(aws.Cognito.ICognitoUserPoolEmailConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolEmailConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfig\"}}]")]
        public virtual void PutLambdaConfig(aws.Cognito.ICognitoUserPoolLambdaConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolLambdaConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPasswordPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolPasswordPolicy\"}}]")]
        public virtual void PutPasswordPolicy(aws.Cognito.ICognitoUserPoolPasswordPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolPasswordPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSmsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolSmsConfiguration\"}}]")]
        public virtual void PutSmsConfiguration(aws.Cognito.ICognitoUserPoolSmsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolSmsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSoftwareTokenMfaConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolSoftwareTokenMfaConfiguration\"}}]")]
        public virtual void PutSoftwareTokenMfaConfiguration(aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsernameConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolUsernameConfiguration\"}}]")]
        public virtual void PutUsernameConfiguration(aws.Cognito.ICognitoUserPoolUsernameConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolUsernameConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserPoolAddOns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolUserPoolAddOns\"}}]")]
        public virtual void PutUserPoolAddOns(aws.Cognito.ICognitoUserPoolUserPoolAddOns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolUserPoolAddOns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerificationMessageTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolVerificationMessageTemplate\"}}]")]
        public virtual void PutVerificationMessageTemplate(aws.Cognito.ICognitoUserPoolVerificationMessageTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolVerificationMessageTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdminCreateUserConfig")]
        public virtual void ResetAdminCreateUserConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAliasAttributes")]
        public virtual void ResetAliasAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoVerifiedAttributes")]
        public virtual void ResetAutoVerifiedAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceConfiguration")]
        public virtual void ResetDeviceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailConfiguration")]
        public virtual void ResetEmailConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailVerificationMessage")]
        public virtual void ResetEmailVerificationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailVerificationSubject")]
        public virtual void ResetEmailVerificationSubject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaConfig")]
        public virtual void ResetLambdaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMfaConfiguration")]
        public virtual void ResetMfaConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordPolicy")]
        public virtual void ResetPasswordPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchema")]
        public virtual void ResetSchema()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsAuthenticationMessage")]
        public virtual void ResetSmsAuthenticationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsConfiguration")]
        public virtual void ResetSmsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsVerificationMessage")]
        public virtual void ResetSmsVerificationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftwareTokenMfaConfiguration")]
        public virtual void ResetSoftwareTokenMfaConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernameAttributes")]
        public virtual void ResetUsernameAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernameConfiguration")]
        public virtual void ResetUsernameConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPoolAddOns")]
        public virtual void ResetUserPoolAddOns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerificationMessageTemplate")]
        public virtual void ResetVerificationMessageTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Cognito.CognitoUserPool))!;

        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfigOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolAdminCreateUserConfigOutputReference AdminCreateUserConfig
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolAdminCreateUserConfigOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolDeviceConfigurationOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolDeviceConfigurationOutputReference DeviceConfiguration
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolDeviceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolEmailConfigurationOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolEmailConfigurationOutputReference EmailConfiguration
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolEmailConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfigOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolLambdaConfigOutputReference LambdaConfig
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolLambdaConfigOutputReference>()!;
        }

        [JsiiProperty(name: "lastModifiedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolPasswordPolicyOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolPasswordPolicyOutputReference PasswordPolicy
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolPasswordPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "smsConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSmsConfigurationOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolSmsConfigurationOutputReference SmsConfiguration
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolSmsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSoftwareTokenMfaConfigurationOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolSoftwareTokenMfaConfigurationOutputReference SoftwareTokenMfaConfiguration
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolSoftwareTokenMfaConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUsernameConfigurationOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolUsernameConfigurationOutputReference UsernameConfiguration
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolUsernameConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUserPoolAddOnsOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolUserPoolAddOnsOutputReference UserPoolAddOns
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolUserPoolAddOnsOutputReference>()!;
        }

        [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolVerificationMessageTemplateOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolVerificationMessageTemplateOutputReference VerificationMessageTemplate
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolVerificationMessageTemplateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminCreateUserConfigInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolAdminCreateUserConfig? AdminCreateUserConfigInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolAdminCreateUserConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AliasAttributesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoVerifiedAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AutoVerifiedAttributesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceConfigurationInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolDeviceConfiguration\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolDeviceConfiguration? DeviceConfigurationInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolDeviceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailConfigurationInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolEmailConfiguration\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolEmailConfiguration? EmailConfigurationInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolEmailConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailVerificationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationSubjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailVerificationSubjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfigInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfig\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolLambdaConfig? LambdaConfigInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolLambdaConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mfaConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MfaConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordPolicyInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolPasswordPolicy\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolPasswordPolicy? PasswordPolicyInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolPasswordPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SchemaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsAuthenticationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmsAuthenticationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsConfigurationInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSmsConfiguration\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolSmsConfiguration? SmsConfigurationInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolSmsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsVerificationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmsVerificationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareTokenMfaConfigurationInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSoftwareTokenMfaConfiguration\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfigurationInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? UsernameAttributesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameConfigurationInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUsernameConfiguration\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolUsernameConfiguration? UsernameConfigurationInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolUsernameConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolAddOnsInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolUserPoolAddOns\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolUserPoolAddOns? UserPoolAddOnsInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolUserPoolAddOns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verificationMessageTemplateInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolVerificationMessageTemplate\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolVerificationMessageTemplate? VerificationMessageTemplateInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolVerificationMessageTemplate?>();
        }

        [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AliasAttributes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AutoVerifiedAttributes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailVerificationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailVerificationSubject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MfaConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}")]
        public virtual object Schema
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsAuthenticationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsVerificationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UsernameAttributes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
