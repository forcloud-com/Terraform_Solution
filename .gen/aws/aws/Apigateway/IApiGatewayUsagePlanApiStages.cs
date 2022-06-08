using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiInterface(nativeType: typeof(IApiGatewayUsagePlanApiStages), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlanApiStages")]
    public interface IApiGatewayUsagePlanApiStages
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#api_id ApiGatewayUsagePlan#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#stage ApiGatewayUsagePlan#stage}.</summary>
        [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}")]
        string Stage
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayUsagePlanApiStages), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlanApiStages")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayUsagePlanApiStages
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#api_id ApiGatewayUsagePlan#api_id}.</summary>
            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#stage ApiGatewayUsagePlan#stage}.</summary>
            [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}")]
            public string Stage
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
