using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfiguration")]
    public class AutoscalingPolicyTargetTrackingConfiguration : aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#target_value AutoscalingPolicy#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        public double TargetValue
        {
            get;
            set;
        }

        /// <summary>customized_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#customized_metric_specification AutoscalingPolicy#customized_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification\"}", isOptional: true)]
        public aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#disable_scale_in AutoscalingPolicy#disable_scale_in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DisableScaleIn
        {
            get;
            set;
        }

        /// <summary>predefined_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_metric_specification AutoscalingPolicy#predefined_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification\"}", isOptional: true)]
        public aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification
        {
            get;
            set;
        }
    }
}
