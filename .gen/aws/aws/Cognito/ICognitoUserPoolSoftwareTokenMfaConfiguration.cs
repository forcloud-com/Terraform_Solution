using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSoftwareTokenMfaConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolSoftwareTokenMfaConfiguration")]
    public interface ICognitoUserPoolSoftwareTokenMfaConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#enabled CognitoUserPool#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSoftwareTokenMfaConfiguration), fullyQualifiedName: "aws.cognito.CognitoUserPoolSoftwareTokenMfaConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolSoftwareTokenMfaConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#enabled CognitoUserPool#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
