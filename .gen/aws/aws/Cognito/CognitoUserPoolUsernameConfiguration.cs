using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolUsernameConfiguration")]
    public class CognitoUserPoolUsernameConfiguration : aws.Cognito.ICognitoUserPoolUsernameConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#case_sensitive CognitoUserPool#case_sensitive}.</summary>
        [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object CaseSensitive
        {
            get;
            set;
        }
    }
}
