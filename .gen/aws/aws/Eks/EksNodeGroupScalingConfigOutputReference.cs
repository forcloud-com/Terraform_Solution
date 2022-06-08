using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiClass(nativeType: typeof(aws.Eks.EksNodeGroupScalingConfigOutputReference), fullyQualifiedName: "aws.eks.EksNodeGroupScalingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksNodeGroupScalingConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksNodeGroupScalingConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroupScalingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroupScalingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "desiredSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupScalingConfig\"}", isOptional: true)]
        public virtual aws.Eks.IEksNodeGroupScalingConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Eks.IEksNodeGroupScalingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
