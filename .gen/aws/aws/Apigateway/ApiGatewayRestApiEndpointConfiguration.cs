using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayRestApiEndpointConfiguration")]
    public class ApiGatewayRestApiEndpointConfiguration : aws.Apigateway.IApiGatewayRestApiEndpointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_rest_api#types ApiGatewayRestApi#types}.</summary>
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Types
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_rest_api#vpc_endpoint_ids ApiGatewayRestApi#vpc_endpoint_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpcEndpointIds
        {
            get;
            set;
        }
    }
}
