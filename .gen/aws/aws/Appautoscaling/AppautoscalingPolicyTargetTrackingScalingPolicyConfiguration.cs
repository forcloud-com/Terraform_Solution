using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration")]
    public class AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration : aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#target_value AppautoscalingPolicy#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        public double TargetValue
        {
            get;
            set;
        }

        /// <summary>customized_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#customized_metric_specification AppautoscalingPolicy#customized_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification\"}", isOptional: true)]
        public aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#disable_scale_in AppautoscalingPolicy#disable_scale_in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DisableScaleIn
        {
            get;
            set;
        }

        /// <summary>predefined_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#predefined_metric_specification AppautoscalingPolicy#predefined_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification\"}", isOptional: true)]
        public aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scale_in_cooldown AppautoscalingPolicy#scale_in_cooldown}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScaleInCooldown
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scale_out_cooldown AppautoscalingPolicy#scale_out_cooldown}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScaleOutCooldown
        {
            get;
            set;
        }
    }
}
