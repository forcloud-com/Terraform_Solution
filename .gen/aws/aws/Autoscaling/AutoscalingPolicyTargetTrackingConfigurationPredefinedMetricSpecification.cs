using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification")]
    public class AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification : aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_metric_type AutoscalingPolicy#predefined_metric_type}.</summary>
        [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}")]
        public string PredefinedMetricType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#resource_label AutoscalingPolicy#resource_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceLabel
        {
            get;
            set;
        }
    }
}
