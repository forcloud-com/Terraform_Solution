using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate), fullyQualifiedName: "aws.cognito.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate")]
    public interface ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_message CognitoUserPool#email_message}.</summary>
        [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_subject CognitoUserPool#email_subject}.</summary>
        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailSubject
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_message CognitoUserPool#sms_message}.</summary>
        [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmsMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate), fullyQualifiedName: "aws.cognito.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_message CognitoUserPool#email_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_subject CognitoUserPool#email_subject}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailSubject
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_message CognitoUserPool#sms_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmsMessage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
