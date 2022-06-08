using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyOutputReference), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingGroupMixedInstancesPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingGroupMixedInstancesPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupMixedInstancesPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupMixedInstancesPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstancesDistribution", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"}}]")]
        public virtual void PutInstancesDistribution(aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"}}]")]
        public virtual void PutLaunchTemplate(aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstancesDistribution")]
        public virtual void ResetInstancesDistribution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "instancesDistribution", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistributionOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistributionOutputReference InstancesDistribution
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistributionOutputReference>()!;
        }

        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOutputReference LaunchTemplate
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancesDistributionInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution? InstancesDistributionInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate? LaunchTemplateInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicy\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
