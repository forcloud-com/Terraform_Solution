using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayUsagePlanThrottleSettings")]
    public class ApiGatewayUsagePlanThrottleSettings : aws.Apigateway.IApiGatewayUsagePlanThrottleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#burst_limit ApiGatewayUsagePlan#burst_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "burstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BurstLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#rate_limit ApiGatewayUsagePlan#rate_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RateLimit
        {
            get;
            set;
        }
    }
}
