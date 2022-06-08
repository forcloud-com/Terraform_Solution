using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiInterface(nativeType: typeof(IApiGatewayUsagePlanThrottleSettings), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlanThrottleSettings")]
    public interface IApiGatewayUsagePlanThrottleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#burst_limit ApiGatewayUsagePlan#burst_limit}.</summary>
        [JsiiProperty(name: "burstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BurstLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#rate_limit ApiGatewayUsagePlan#rate_limit}.</summary>
        [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RateLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayUsagePlanThrottleSettings), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlanThrottleSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayUsagePlanThrottleSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#burst_limit ApiGatewayUsagePlan#burst_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "burstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BurstLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#rate_limit ApiGatewayUsagePlan#rate_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RateLimit
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
