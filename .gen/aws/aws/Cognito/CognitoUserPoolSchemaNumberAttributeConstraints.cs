using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolSchemaNumberAttributeConstraints")]
    public class CognitoUserPoolSchemaNumberAttributeConstraints : aws.Cognito.ICognitoUserPoolSchemaNumberAttributeConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#max_value CognitoUserPool#max_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#min_value CognitoUserPool#min_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinValue
        {
            get;
            set;
        }
    }
}
