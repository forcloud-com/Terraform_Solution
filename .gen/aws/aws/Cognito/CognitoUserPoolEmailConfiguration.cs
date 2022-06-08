using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolEmailConfiguration")]
    public class CognitoUserPoolEmailConfiguration : aws.Cognito.ICognitoUserPoolEmailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_sending_account CognitoUserPool#email_sending_account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailSendingAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailSendingAccount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#from_email_address CognitoUserPool#from_email_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fromEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FromEmailAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#reply_to_email_address CognitoUserPool#reply_to_email_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replyToEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplyToEmailAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#source_arn CognitoUserPool#source_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceArn
        {
            get;
            set;
        }
    }
}
