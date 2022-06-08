using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclVisibilityConfig")]
    public class Wafv2WebAclVisibilityConfig : aws.Wafv2.IWafv2WebAclVisibilityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#cloudwatch_metrics_enabled Wafv2WebAcl#cloudwatch_metrics_enabled}.</summary>
        [JsiiProperty(name: "cloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object CloudwatchMetricsEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#metric_name Wafv2WebAcl#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#sampled_requests_enabled Wafv2WebAcl#sampled_requests_enabled}.</summary>
        [JsiiProperty(name: "sampledRequestsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object SampledRequestsEnabled
        {
            get;
            set;
        }
    }
}
