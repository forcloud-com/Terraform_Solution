using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicy), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicy")]
    public interface IAutoscalingGroupMixedInstancesPolicy
    {
        /// <summary>launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template AutoscalingGroup#launch_template}
        /// </remarks>
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"}")]
        aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate LaunchTemplate
        {
            get;
        }

        /// <summary>instances_distribution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#instances_distribution AutoscalingGroup#instances_distribution}
        /// </remarks>
        [JsiiProperty(name: "instancesDistribution", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution? InstancesDistribution
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicy), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template AutoscalingGroup#launch_template}
            /// </remarks>
            [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"}")]
            public aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate LaunchTemplate
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate>()!;
            }

            /// <summary>instances_distribution block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#instances_distribution AutoscalingGroup#instances_distribution}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instancesDistribution", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"}", isOptional: true)]
            public aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution? InstancesDistribution
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution?>();
            }
        }
    }
}
