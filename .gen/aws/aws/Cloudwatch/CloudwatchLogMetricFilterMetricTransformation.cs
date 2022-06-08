using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatch.CloudwatchLogMetricFilterMetricTransformation")]
    public class CloudwatchLogMetricFilterMetricTransformation : aws.Cloudwatch.ICloudwatchLogMetricFilterMetricTransformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#name CloudwatchLogMetricFilter#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#namespace CloudwatchLogMetricFilter#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#value CloudwatchLogMetricFilter#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#default_value CloudwatchLogMetricFilter#default_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultValue
        {
            get;
            set;
        }
    }
}
