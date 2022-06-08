using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iot.IotTopicRuleErrorActionCloudwatchMetric")]
    public class IotTopicRuleErrorActionCloudwatchMetric : aws.Iot.IIotTopicRuleErrorActionCloudwatchMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#metric_name IotTopicRule#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#metric_namespace IotTopicRule#metric_namespace}.</summary>
        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricNamespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#metric_unit IotTopicRule#metric_unit}.</summary>
        [JsiiProperty(name: "metricUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricUnit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#metric_value IotTopicRule#metric_value}.</summary>
        [JsiiProperty(name: "metricValue", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#metric_timestamp IotTopicRule#metric_timestamp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricTimestamp
        {
            get;
            set;
        }
    }
}
