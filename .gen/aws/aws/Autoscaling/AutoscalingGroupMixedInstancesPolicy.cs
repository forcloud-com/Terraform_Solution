using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicy")]
    public class AutoscalingGroupMixedInstancesPolicy : aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy
    {
        /// <summary>launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template AutoscalingGroup#launch_template}
        /// </remarks>
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"}")]
        public aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate LaunchTemplate
        {
            get;
            set;
        }

        /// <summary>instances_distribution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#instances_distribution AutoscalingGroup#instances_distribution}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instancesDistribution", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"}", isOptional: true)]
        public aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution? InstancesDistribution
        {
            get;
            set;
        }
    }
}
