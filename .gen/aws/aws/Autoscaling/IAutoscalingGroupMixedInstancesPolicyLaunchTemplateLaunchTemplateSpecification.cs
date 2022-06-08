using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification")]
    public interface IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_id AutoscalingGroup#launch_template_id}.</summary>
        [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchTemplateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_name AutoscalingGroup#launch_template_name}.</summary>
        [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchTemplateName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#version AutoscalingGroup#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_id AutoscalingGroup#launch_template_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchTemplateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_name AutoscalingGroup#launch_template_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchTemplateName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#version AutoscalingGroup#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
