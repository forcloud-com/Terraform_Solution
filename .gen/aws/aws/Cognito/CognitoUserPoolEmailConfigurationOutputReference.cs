using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiClass(nativeType: typeof(aws.Cognito.CognitoUserPoolEmailConfigurationOutputReference), fullyQualifiedName: "aws.cognito.CognitoUserPoolEmailConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CognitoUserPoolEmailConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CognitoUserPoolEmailConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolEmailConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolEmailConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEmailSendingAccount")]
        public virtual void ResetEmailSendingAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFromEmailAddress")]
        public virtual void ResetFromEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplyToEmailAddress")]
        public virtual void ResetReplyToEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceArn")]
        public virtual void ResetSourceArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailSendingAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailSendingAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromEmailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FromEmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replyToEmailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplyToEmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "emailSendingAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailSendingAccount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fromEmailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FromEmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replyToEmailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplyToEmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolEmailConfiguration\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolEmailConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolEmailConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
