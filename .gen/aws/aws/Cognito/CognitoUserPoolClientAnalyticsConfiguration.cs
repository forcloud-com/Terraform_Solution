using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolClientAnalyticsConfiguration")]
    public class CognitoUserPoolClientAnalyticsConfiguration : aws.Cognito.ICognitoUserPoolClientAnalyticsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#application_id CognitoUserPoolClient#application_id}.</summary>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public string ApplicationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#external_id CognitoUserPoolClient#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#role_arn CognitoUserPoolClient#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#user_data_shared CognitoUserPoolClient#user_data_shared}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userDataShared", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UserDataShared
        {
            get;
            set;
        }
    }
}
