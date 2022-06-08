using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolClientAnalyticsConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolClientAnalyticsConfiguration")]
    public interface ICognitoUserPoolClientAnalyticsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#application_id CognitoUserPoolClient#application_id}.</summary>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#external_id CognitoUserPoolClient#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#role_arn CognitoUserPoolClient#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#user_data_shared CognitoUserPoolClient#user_data_shared}.</summary>
        [JsiiProperty(name: "userDataShared", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserDataShared
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolClientAnalyticsConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolClientAnalyticsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolClientAnalyticsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#application_id CognitoUserPoolClient#application_id}.</summary>
            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#external_id CognitoUserPoolClient#external_id}.</summary>
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#role_arn CognitoUserPoolClient#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool_client#user_data_shared CognitoUserPoolClient#user_data_shared}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userDataShared", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UserDataShared
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
