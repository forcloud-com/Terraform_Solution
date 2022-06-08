using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOutputReference), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingGroupMixedInstancesPolicyLaunchTemplateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingGroupMixedInstancesPolicyLaunchTemplateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupMixedInstancesPolicyLaunchTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupMixedInstancesPolicyLaunchTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLaunchTemplateSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification\"}}]")]
        public virtual void PutLaunchTemplateSpecification(aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOverride")]
        public virtual void ResetOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationOutputReference LaunchTemplateSpecification
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification? LaunchTemplateSpecificationInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride\"},\"kind\":\"array\"}}]}}")]
        public virtual object Override
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
