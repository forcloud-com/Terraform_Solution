using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification")]
    public class AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification : aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#metric_name AppautoscalingPolicy#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#namespace AppautoscalingPolicy#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#statistic AppautoscalingPolicy#statistic}.</summary>
        [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}")]
        public string Statistic
        {
            get;
            set;
        }

        /// <summary>dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#dimensions AppautoscalingPolicy#dimensions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Dimensions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#unit AppautoscalingPolicy#unit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Unit
        {
            get;
            set;
        }
    }
}
