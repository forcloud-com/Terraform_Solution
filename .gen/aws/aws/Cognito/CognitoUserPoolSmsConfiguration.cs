using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolSmsConfiguration")]
    public class CognitoUserPoolSmsConfiguration : aws.Cognito.ICognitoUserPoolSmsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#external_id CognitoUserPool#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sns_caller_arn CognitoUserPool#sns_caller_arn}.</summary>
        [JsiiProperty(name: "snsCallerArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SnsCallerArn
        {
            get;
            set;
        }
    }
}
