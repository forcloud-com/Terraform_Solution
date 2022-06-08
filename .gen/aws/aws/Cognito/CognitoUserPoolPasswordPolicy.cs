using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolPasswordPolicy")]
    public class CognitoUserPoolPasswordPolicy : aws.Cognito.ICognitoUserPoolPasswordPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#minimum_length CognitoUserPool#minimum_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_lowercase CognitoUserPool#require_lowercase}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireLowercase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireLowercase
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_numbers CognitoUserPool#require_numbers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireNumbers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireNumbers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_symbols CognitoUserPool#require_symbols}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireSymbols", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireSymbols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_uppercase CognitoUserPool#require_uppercase}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireUppercase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireUppercase
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#temporary_password_validity_days CognitoUserPool#temporary_password_validity_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "temporaryPasswordValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TemporaryPasswordValidityDays
        {
            get;
            set;
        }
    }
}
