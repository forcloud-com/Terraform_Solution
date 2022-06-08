using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolUsernameConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolUsernameConfiguration")]
    public interface ICognitoUserPoolUsernameConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#case_sensitive CognitoUserPool#case_sensitive}.</summary>
        [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object CaseSensitive
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolUsernameConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolUsernameConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolUsernameConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#case_sensitive CognitoUserPool#case_sensitive}.</summary>
            [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object CaseSensitive
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
