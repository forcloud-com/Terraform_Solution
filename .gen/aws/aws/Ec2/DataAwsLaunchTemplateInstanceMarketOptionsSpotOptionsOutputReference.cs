using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.DataAwsLaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference), fullyQualifiedName: "aws.ec2.DataAwsLaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsLaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsLaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockDurationMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInterruptionBehavior
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxPrice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spotInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotInstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidUntil
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
        public virtual aws.Ec2.IDataAwsLaunchTemplateInstanceMarketOptionsSpotOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsLaunchTemplateInstanceMarketOptionsSpotOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
