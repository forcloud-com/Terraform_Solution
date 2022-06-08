using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification")]
    public class AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification : aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#predefined_metric_type AppautoscalingPolicy#predefined_metric_type}.</summary>
        [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}")]
        public string PredefinedMetricType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#resource_label AppautoscalingPolicy#resource_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceLabel
        {
            get;
            set;
        }
    }
}
