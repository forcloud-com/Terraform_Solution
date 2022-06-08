using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatch.CloudwatchMetricAlarmMetricQuery")]
    public class CloudwatchMetricAlarmMetricQuery : aws.Cloudwatch.ICloudwatchMetricAlarmMetricQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#id CloudwatchMetricAlarm#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#expression CloudwatchMetricAlarm#expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#label CloudwatchMetricAlarm#label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#metric CloudwatchMetricAlarm#metric}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"aws.cloudwatch.CloudwatchMetricAlarmMetricQueryMetric\"}", isOptional: true)]
        public aws.Cloudwatch.ICloudwatchMetricAlarmMetricQueryMetric? Metric
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#return_data CloudwatchMetricAlarm#return_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "returnData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ReturnData
        {
            get;
            set;
        }
    }
}
