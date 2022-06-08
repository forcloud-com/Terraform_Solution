using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.LaunchTemplateCapacityReservationSpecificationOutputReference), fullyQualifiedName: "aws.ec2.LaunchTemplateCapacityReservationSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LaunchTemplateCapacityReservationSpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LaunchTemplateCapacityReservationSpecificationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateCapacityReservationSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateCapacityReservationSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacityReservationTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget\"}}]")]
        public virtual void PutCapacityReservationTarget(aws.Ec2.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityReservationPreference")]
        public virtual void ResetCapacityReservationPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationTarget")]
        public virtual void ResetCapacityReservationTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecificationCapacityReservationTargetOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateCapacityReservationSpecificationCapacityReservationTargetOutputReference CapacityReservationTarget
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateCapacityReservationSpecificationCapacityReservationTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationPreferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTargetInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTargetInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget?>();
        }

        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationPreference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecification\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateCapacityReservationSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateCapacityReservationSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
