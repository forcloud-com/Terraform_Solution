using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification")]
    public class AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification : aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_name AutoscalingPolicy#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#namespace AutoscalingPolicy#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#statistic AutoscalingPolicy#statistic}.</summary>
        [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}")]
        public string Statistic
        {
            get;
            set;
        }

        /// <summary>metric_dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_dimension AutoscalingPolicy#metric_dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricDimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MetricDimension
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#unit AutoscalingPolicy#unit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Unit
        {
            get;
            set;
        }
    }
}
