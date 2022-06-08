using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiInterface(nativeType: typeof(IApiGatewayRestApiEndpointConfiguration), fullyQualifiedName: "aws.apigateway.ApiGatewayRestApiEndpointConfiguration")]
    public interface IApiGatewayRestApiEndpointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_rest_api#types ApiGatewayRestApi#types}.</summary>
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Types
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_rest_api#vpc_endpoint_ids ApiGatewayRestApi#vpc_endpoint_ids}.</summary>
        [JsiiProperty(name: "vpcEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcEndpointIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayRestApiEndpointConfiguration), fullyQualifiedName: "aws.apigateway.ApiGatewayRestApiEndpointConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayRestApiEndpointConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_rest_api#types ApiGatewayRestApi#types}.</summary>
            [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Types
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_rest_api#vpc_endpoint_ids ApiGatewayRestApi#vpc_endpoint_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcEndpointIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
