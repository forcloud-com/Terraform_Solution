using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiInterface(nativeType: typeof(IApiGatewayUsagePlanQuotaSettings), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlanQuotaSettings")]
    public interface IApiGatewayUsagePlanQuotaSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#limit ApiGatewayUsagePlan#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        double Limit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#period ApiGatewayUsagePlan#period}.</summary>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
        string Period
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#offset ApiGatewayUsagePlan#offset}.</summary>
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Offset
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayUsagePlanQuotaSettings), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlanQuotaSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayUsagePlanQuotaSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#limit ApiGatewayUsagePlan#limit}.</summary>
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
            public double Limit
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#period ApiGatewayUsagePlan#period}.</summary>
            [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
            public string Period
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#offset ApiGatewayUsagePlan#offset}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Offset
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
