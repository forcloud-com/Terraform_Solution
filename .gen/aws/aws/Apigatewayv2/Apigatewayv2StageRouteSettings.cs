using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigatewayv2.Apigatewayv2StageRouteSettings")]
    public class Apigatewayv2StageRouteSettings : aws.Apigatewayv2.IApigatewayv2StageRouteSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#route_key Apigatewayv2Stage#route_key}.</summary>
        [JsiiProperty(name: "routeKey", typeJson: "{\"primitive\":\"string\"}")]
        public string RouteKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#data_trace_enabled Apigatewayv2Stage#data_trace_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataTraceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DataTraceEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#detailed_metrics_enabled Apigatewayv2Stage#detailed_metrics_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "detailedMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DetailedMetricsEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#logging_level Apigatewayv2Stage#logging_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loggingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoggingLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#throttling_burst_limit Apigatewayv2Stage#throttling_burst_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "throttlingBurstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThrottlingBurstLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#throttling_rate_limit Apigatewayv2Stage#throttling_rate_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "throttlingRateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThrottlingRateLimit
        {
            get;
            set;
        }
    }
}
