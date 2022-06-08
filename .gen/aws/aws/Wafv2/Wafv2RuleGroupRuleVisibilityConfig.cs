using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleVisibilityConfig")]
    public class Wafv2RuleGroupRuleVisibilityConfig : aws.Wafv2.IWafv2RuleGroupRuleVisibilityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#cloudwatch_metrics_enabled Wafv2RuleGroup#cloudwatch_metrics_enabled}.</summary>
        [JsiiProperty(name: "cloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object CloudwatchMetricsEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#metric_name Wafv2RuleGroup#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#sampled_requests_enabled Wafv2RuleGroup#sampled_requests_enabled}.</summary>
        [JsiiProperty(name: "sampledRequestsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object SampledRequestsEnabled
        {
            get;
            set;
        }
    }
}
