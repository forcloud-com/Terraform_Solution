using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplate), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplate")]
    public interface IAutoscalingGroupMixedInstancesPolicyLaunchTemplate
    {
        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_specification AutoscalingGroup#launch_template_specification}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification\"}")]
        aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification LaunchTemplateSpecification
        {
            get;
        }

        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#override AutoscalingGroup#override}
        /// </remarks>
        [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Override
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplate), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_specification AutoscalingGroup#launch_template_specification}
            /// </remarks>
            [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification\"}")]
            public aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification LaunchTemplateSpecification
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification>()!;
            }

            /// <summary>override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#override AutoscalingGroup#override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Override
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
