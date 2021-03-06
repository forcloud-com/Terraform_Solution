using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2StageAccessLogSettings), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2StageAccessLogSettings")]
    public interface IApigatewayv2StageAccessLogSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#destination_arn Apigatewayv2Stage#destination_arn}.</summary>
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#format Apigatewayv2Stage#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2StageAccessLogSettings), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2StageAccessLogSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2.IApigatewayv2StageAccessLogSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#destination_arn Apigatewayv2Stage#destination_arn}.</summary>
            [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#format Apigatewayv2Stage#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
