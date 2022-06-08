using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiInterface(nativeType: typeof(IApiGatewayStageAccessLogSettings), fullyQualifiedName: "aws.apigateway.ApiGatewayStageAccessLogSettings")]
    public interface IApiGatewayStageAccessLogSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#destination_arn ApiGatewayStage#destination_arn}.</summary>
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#format ApiGatewayStage#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayStageAccessLogSettings), fullyQualifiedName: "aws.apigateway.ApiGatewayStageAccessLogSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayStageAccessLogSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#destination_arn ApiGatewayStage#destination_arn}.</summary>
            [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#format ApiGatewayStage#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
