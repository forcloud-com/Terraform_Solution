using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolLambdaConfig), fullyQualifiedName: "aws.cognito.CognitoUserPoolLambdaConfig")]
    public interface ICognitoUserPoolLambdaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#create_auth_challenge CognitoUserPool#create_auth_challenge}.</summary>
        [JsiiProperty(name: "createAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreateAuthChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#custom_message CognitoUserPool#custom_message}.</summary>
        [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#define_auth_challenge CognitoUserPool#define_auth_challenge}.</summary>
        [JsiiProperty(name: "defineAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefineAuthChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#post_authentication CognitoUserPool#post_authentication}.</summary>
        [JsiiProperty(name: "postAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#post_confirmation CognitoUserPool#post_confirmation}.</summary>
        [JsiiProperty(name: "postConfirmation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostConfirmation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#pre_authentication CognitoUserPool#pre_authentication}.</summary>
        [JsiiProperty(name: "preAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#pre_sign_up CognitoUserPool#pre_sign_up}.</summary>
        [JsiiProperty(name: "preSignUp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreSignUp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#pre_token_generation CognitoUserPool#pre_token_generation}.</summary>
        [JsiiProperty(name: "preTokenGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreTokenGeneration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#user_migration CognitoUserPool#user_migration}.</summary>
        [JsiiProperty(name: "userMigration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserMigration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#verify_auth_challenge_response CognitoUserPool#verify_auth_challenge_response}.</summary>
        [JsiiProperty(name: "verifyAuthChallengeResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerifyAuthChallengeResponse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolLambdaConfig), fullyQualifiedName: "aws.cognito.CognitoUserPoolLambdaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolLambdaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#create_auth_challenge CognitoUserPool#create_auth_challenge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreateAuthChallenge
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#custom_message CognitoUserPool#custom_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#define_auth_challenge CognitoUserPool#define_auth_challenge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defineAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefineAuthChallenge
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#post_authentication CognitoUserPool#post_authentication}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "postAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostAuthentication
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#post_confirmation CognitoUserPool#post_confirmation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "postConfirmation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostConfirmation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#pre_authentication CognitoUserPool#pre_authentication}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreAuthentication
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#pre_sign_up CognitoUserPool#pre_sign_up}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preSignUp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreSignUp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#pre_token_generation CognitoUserPool#pre_token_generation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preTokenGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreTokenGeneration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#user_migration CognitoUserPool#user_migration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userMigration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserMigration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#verify_auth_challenge_response CognitoUserPool#verify_auth_challenge_response}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifyAuthChallengeResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerifyAuthChallengeResponse
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
