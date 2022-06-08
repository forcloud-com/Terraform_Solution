using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiByValue(fqn: "aws.cognito.CognitoIdentityPoolCognitoIdentityProviders")]
    public class CognitoIdentityPoolCognitoIdentityProviders : aws.Cognito.ICognitoIdentityPoolCognitoIdentityProviders
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#client_id CognitoIdentityPool#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#provider_name CognitoIdentityPool#provider_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProviderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool#server_side_token_check CognitoIdentityPool#server_side_token_check}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideTokenCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ServerSideTokenCheck
        {
            get;
            set;
        }
    }
}
