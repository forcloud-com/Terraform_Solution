using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatch.CloudwatchMetricAlarmMetricQueryMetric")]
    public class CloudwatchMetricAlarmMetricQueryMetric : aws.Cloudwatch.ICloudwatchMetricAlarmMetricQueryMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#metric_name CloudwatchMetricAlarm#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#period CloudwatchMetricAlarm#period}.</summary>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        public double Period
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#stat CloudwatchMetricAlarm#stat}.</summary>
        [JsiiProperty(name: "stat", typeJson: "{\"primitive\":\"string\"}")]
        public string Stat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#dimensions CloudwatchMetricAlarm#dimensions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Dimensions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#namespace CloudwatchMetricAlarm#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#unit CloudwatchMetricAlarm#unit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Unit
        {
            get;
            set;
        }
    }
}
