using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification")]
    public class AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification : aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_id AutoscalingGroup#launch_template_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LaunchTemplateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_name AutoscalingGroup#launch_template_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LaunchTemplateName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#version AutoscalingGroup#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
