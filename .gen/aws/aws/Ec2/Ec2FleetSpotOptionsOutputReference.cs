using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2FleetSpotOptionsOutputReference), fullyQualifiedName: "aws.ec2.Ec2FleetSpotOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Ec2FleetSpotOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Ec2FleetSpotOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetSpotOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetSpotOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllocationStrategy")]
        public virtual void ResetAllocationStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceInterruptionBehavior")]
        public virtual void ResetInstanceInterruptionBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstancePoolsToUseCount")]
        public virtual void ResetInstancePoolsToUseCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllocationStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceInterruptionBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancePoolsToUseCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstancePoolsToUseCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllocationStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInterruptionBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instancePoolsToUseCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstancePoolsToUseCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptions\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetSpotOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetSpotOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
