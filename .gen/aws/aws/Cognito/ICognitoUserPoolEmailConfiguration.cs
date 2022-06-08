using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolEmailConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolEmailConfiguration")]
    public interface ICognitoUserPoolEmailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_sending_account CognitoUserPool#email_sending_account}.</summary>
        [JsiiProperty(name: "emailSendingAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailSendingAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#from_email_address CognitoUserPool#from_email_address}.</summary>
        [JsiiProperty(name: "fromEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FromEmailAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#reply_to_email_address CognitoUserPool#reply_to_email_address}.</summary>
        [JsiiProperty(name: "replyToEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplyToEmailAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#source_arn CognitoUserPool#source_arn}.</summary>
        [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolEmailConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolEmailConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolEmailConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_sending_account CognitoUserPool#email_sending_account}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailSendingAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailSendingAccount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#from_email_address CognitoUserPool#from_email_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fromEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FromEmailAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#reply_to_email_address CognitoUserPool#reply_to_email_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replyToEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplyToEmailAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#source_arn CognitoUserPool#source_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
