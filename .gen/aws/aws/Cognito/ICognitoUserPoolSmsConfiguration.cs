using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSmsConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolSmsConfiguration")]
    public interface ICognitoUserPoolSmsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#external_id CognitoUserPool#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sns_caller_arn CognitoUserPool#sns_caller_arn}.</summary>
        [JsiiProperty(name: "snsCallerArn", typeJson: "{\"primitive\":\"string\"}")]
        string SnsCallerArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSmsConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolSmsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolSmsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#external_id CognitoUserPool#external_id}.</summary>
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sns_caller_arn CognitoUserPool#sns_caller_arn}.</summary>
            [JsiiProperty(name: "snsCallerArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SnsCallerArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
