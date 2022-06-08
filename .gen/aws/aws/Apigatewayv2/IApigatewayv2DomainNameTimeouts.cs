using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2DomainNameTimeouts), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2DomainNameTimeouts")]
    public interface IApigatewayv2DomainNameTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#update Apigatewayv2DomainName#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2DomainNameTimeouts), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2DomainNameTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2.IApigatewayv2DomainNameTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#update Apigatewayv2DomainName#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
