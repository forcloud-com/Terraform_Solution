using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolSoftwareTokenMfaConfiguration")]
    public class CognitoUserPoolSoftwareTokenMfaConfiguration : aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#enabled CognitoUserPool#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }
    }
}
