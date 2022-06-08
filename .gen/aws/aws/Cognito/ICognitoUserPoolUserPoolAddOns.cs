using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolUserPoolAddOns), fullyQualifiedName: "aws.cognito.CognitoUserPoolUserPoolAddOns")]
    public interface ICognitoUserPoolUserPoolAddOns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#advanced_security_mode CognitoUserPool#advanced_security_mode}.</summary>
        [JsiiProperty(name: "advancedSecurityMode", typeJson: "{\"primitive\":\"string\"}")]
        string AdvancedSecurityMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolUserPoolAddOns), fullyQualifiedName: "aws.cognito.CognitoUserPoolUserPoolAddOns")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolUserPoolAddOns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#advanced_security_mode CognitoUserPool#advanced_security_mode}.</summary>
            [JsiiProperty(name: "advancedSecurityMode", typeJson: "{\"primitive\":\"string\"}")]
            public string AdvancedSecurityMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
