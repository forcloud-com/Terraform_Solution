using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension")]
    public class AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension : aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#name AutoscalingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#value AutoscalingPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
