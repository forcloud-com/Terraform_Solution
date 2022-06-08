using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appautoscaling.AppautoscalingPolicyStepAdjustment")]
    public class AppautoscalingPolicyStepAdjustment : aws.Appautoscaling.IAppautoscalingPolicyStepAdjustment
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scaling_adjustment AppautoscalingPolicy#scaling_adjustment}.</summary>
        [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}")]
        public double ScalingAdjustment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#metric_interval_lower_bound AppautoscalingPolicy#metric_interval_lower_bound}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricIntervalLowerBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricIntervalLowerBound
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#metric_interval_upper_bound AppautoscalingPolicy#metric_interval_upper_bound}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricIntervalUpperBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricIntervalUpperBound
        {
            get;
            set;
        }
    }
}
