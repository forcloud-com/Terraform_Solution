using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolLambdaConfig")]
    public class CognitoUserPoolLambdaConfig : aws.Cognito.ICognitoUserPoolLambdaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#create_auth_challenge CognitoUserPool#create_auth_challenge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreateAuthChallenge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#custom_message CognitoUserPool#custom_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#define_auth_challenge CognitoUserPool#define_auth_challenge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defineAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefineAuthChallenge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#post_authentication CognitoUserPool#post_authentication}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "postAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PostAuthentication
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#post_confirmation CognitoUserPool#post_confirmation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "postConfirmation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PostConfirmation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#pre_authentication CognitoUserPool#pre_authentication}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreAuthentication
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#pre_sign_up CognitoUserPool#pre_sign_up}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preSignUp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreSignUp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#pre_token_generation CognitoUserPool#pre_token_generation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preTokenGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreTokenGeneration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#user_migration CognitoUserPool#user_migration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userMigration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserMigration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#verify_auth_challenge_response CognitoUserPool#verify_auth_challenge_response}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifyAuthChallengeResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerifyAuthChallengeResponse
        {
            get;
            set;
        }
    }
}
