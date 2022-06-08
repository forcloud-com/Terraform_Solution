using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiInterface(nativeType: typeof(IApiGatewayApiKeyStageKey), fullyQualifiedName: "aws.apigateway.ApiGatewayApiKeyStageKey")]
    public interface IApiGatewayApiKeyStageKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_api_key#rest_api_id ApiGatewayApiKey#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        string RestApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_api_key#stage_name ApiGatewayApiKey#stage_name}.</summary>
        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
        string StageName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayApiKeyStageKey), fullyQualifiedName: "aws.apigateway.ApiGatewayApiKeyStageKey")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayApiKeyStageKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_api_key#rest_api_id ApiGatewayApiKey#rest_api_id}.</summary>
            [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
            public string RestApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_api_key#stage_name ApiGatewayApiKey#stage_name}.</summary>
            [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
            public string StageName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
