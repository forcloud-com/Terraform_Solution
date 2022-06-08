using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsCapacityProviderAutoScalingGroupProviderOutputReference), fullyQualifiedName: "aws.ecs.EcsCapacityProviderAutoScalingGroupProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsCapacityProviderAutoScalingGroupProviderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsCapacityProviderAutoScalingGroupProviderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProviderAutoScalingGroupProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProviderAutoScalingGroupProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putManagedScaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"}}]")]
        public virtual void PutManagedScaling(aws.Ecs.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetManagedScaling")]
        public virtual void ResetManagedScaling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedTerminationProtection")]
        public virtual void ResetManagedTerminationProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "managedScaling", typeJson: "{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference\"}")]
        public virtual aws.Ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference ManagedScaling
        {
            get => GetInstanceProperty<aws.Ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingGroupArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoScalingGroupArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedScalingInput", typeJson: "{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling? ManagedScalingInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedTerminationProtectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedTerminationProtectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingGroupArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedTerminationProtection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedTerminationProtection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProvider\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider? InternalValue
        {
            get => GetInstanceProperty<aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}
