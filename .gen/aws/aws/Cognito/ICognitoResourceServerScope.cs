using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoResourceServerScope), fullyQualifiedName: "aws.cognito.CognitoResourceServerScope")]
    public interface ICognitoResourceServerScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_resource_server#scope_description CognitoResourceServer#scope_description}.</summary>
        [JsiiProperty(name: "scopeDescription", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeDescription
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_resource_server#scope_name CognitoResourceServer#scope_name}.</summary>
        [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoResourceServerScope), fullyQualifiedName: "aws.cognito.CognitoResourceServerScope")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoResourceServerScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_resource_server#scope_description CognitoResourceServer#scope_description}.</summary>
            [JsiiProperty(name: "scopeDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_resource_server#scope_name CognitoResourceServer#scope_name}.</summary>
            [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
