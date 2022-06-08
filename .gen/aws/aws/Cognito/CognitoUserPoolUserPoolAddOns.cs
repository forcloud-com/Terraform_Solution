using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolUserPoolAddOns")]
    public class CognitoUserPoolUserPoolAddOns : aws.Cognito.ICognitoUserPoolUserPoolAddOns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#advanced_security_mode CognitoUserPool#advanced_security_mode}.</summary>
        [JsiiProperty(name: "advancedSecurityMode", typeJson: "{\"primitive\":\"string\"}")]
        public string AdvancedSecurityMode
        {
            get;
            set;
        }
    }
}
