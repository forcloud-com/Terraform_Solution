using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride")]
    public interface IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#instance_type AutoscalingGroup#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#weighted_capacity AutoscalingGroup#weighted_capacity}.</summary>
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeightedCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#instance_type AutoscalingGroup#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#weighted_capacity AutoscalingGroup#weighted_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeightedCapacity
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
