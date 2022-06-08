using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiInterface(nativeType: typeof(IApiGatewayDomainNameEndpointConfiguration), fullyQualifiedName: "aws.apigateway.ApiGatewayDomainNameEndpointConfiguration")]
    public interface IApiGatewayDomainNameEndpointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#types ApiGatewayDomainName#types}.</summary>
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Types
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayDomainNameEndpointConfiguration), fullyQualifiedName: "aws.apigateway.ApiGatewayDomainNameEndpointConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayDomainNameEndpointConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#types ApiGatewayDomainName#types}.</summary>
            [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Types
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
