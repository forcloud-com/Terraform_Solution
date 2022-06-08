using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayDomainNameEndpointConfiguration")]
    public class ApiGatewayDomainNameEndpointConfiguration : aws.Apigateway.IApiGatewayDomainNameEndpointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#types ApiGatewayDomainName#types}.</summary>
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Types
        {
            get;
            set;
        }
    }
}
