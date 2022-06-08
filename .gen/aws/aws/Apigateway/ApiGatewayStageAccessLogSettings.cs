using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayStageAccessLogSettings")]
    public class ApiGatewayStageAccessLogSettings : aws.Apigateway.IApiGatewayStageAccessLogSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#destination_arn ApiGatewayStage#destination_arn}.</summary>
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#format ApiGatewayStage#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }
    }
}
