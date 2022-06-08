using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie
{
    [JsiiClass(nativeType: typeof(aws.Macie.MacieS3BucketAssociationClassificationTypeOutputReference), fullyQualifiedName: "aws.macie.MacieS3BucketAssociationClassificationTypeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MacieS3BucketAssociationClassificationTypeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MacieS3BucketAssociationClassificationTypeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MacieS3BucketAssociationClassificationTypeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MacieS3BucketAssociationClassificationTypeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetContinuous")]
        public virtual void ResetContinuous()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOneTime")]
        public virtual void ResetOneTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "continuousInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContinuousInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oneTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OneTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "continuous", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Continuous
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oneTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OneTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.macie.MacieS3BucketAssociationClassificationType\"}", isOptional: true)]
        public virtual aws.Macie.IMacieS3BucketAssociationClassificationType? InternalValue
        {
            get => GetInstanceProperty<aws.Macie.IMacieS3BucketAssociationClassificationType?>();
            set => SetInstanceProperty(value);
        }
    }
}
