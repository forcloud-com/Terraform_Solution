using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplate")]
    public class AutoscalingGroupMixedInstancesPolicyLaunchTemplate : aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate
    {
        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_specification AutoscalingGroup#launch_template_specification}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification\"}")]
        public aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification LaunchTemplateSpecification
        {
            get;
            set;
        }

        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#override AutoscalingGroup#override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Override
        {
            get;
            set;
        }
    }
}
