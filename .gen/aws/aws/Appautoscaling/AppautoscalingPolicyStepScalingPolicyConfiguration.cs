using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    [JsiiByValue(fqn: "aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfiguration")]
    public class AppautoscalingPolicyStepScalingPolicyConfiguration : aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#adjustment_type AppautoscalingPolicy#adjustment_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdjustmentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#cooldown AppautoscalingPolicy#cooldown}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Cooldown
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#metric_aggregation_type AppautoscalingPolicy#metric_aggregation_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricAggregationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#min_adjustment_magnitude AppautoscalingPolicy#min_adjustment_magnitude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinAdjustmentMagnitude
        {
            get;
            set;
        }

        /// <summary>step_adjustment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#step_adjustment AppautoscalingPolicy#step_adjustment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StepAdjustment
        {
            get;
            set;
        }
    }
}
