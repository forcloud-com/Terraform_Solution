using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2FleetTargetCapacitySpecificationOutputReference), fullyQualifiedName: "aws.ec2.Ec2FleetTargetCapacitySpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Ec2FleetTargetCapacitySpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Ec2FleetTargetCapacitySpecificationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetTargetCapacitySpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetTargetCapacitySpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOnDemandTargetCapacity")]
        public virtual void ResetOnDemandTargetCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotTargetCapacity")]
        public virtual void ResetSpotTargetCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTargetCapacityTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultTargetCapacityTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandTargetCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OnDemandTargetCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotTargetCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SpotTargetCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalTargetCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalTargetCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "defaultTargetCapacityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultTargetCapacityType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onDemandTargetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnDemandTargetCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotTargetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpotTargetCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalTargetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalTargetCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetTargetCapacitySpecification\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetTargetCapacitySpecification? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetTargetCapacitySpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
