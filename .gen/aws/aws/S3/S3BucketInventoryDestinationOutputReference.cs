using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketInventoryDestinationOutputReference), fullyQualifiedName: "aws.s3.S3BucketInventoryDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketInventoryDestinationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketInventoryDestinationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketInventoryDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketInventoryDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucket\"}}]")]
        public virtual void PutBucket(aws.S3.IS3BucketInventoryDestinationBucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketInventoryDestinationBucket)}, new object[]{@value});
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketOutputReference\"}")]
        public virtual aws.S3.S3BucketInventoryDestinationBucketOutputReference Bucket
        {
            get => GetInstanceProperty<aws.S3.S3BucketInventoryDestinationBucketOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucket\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketInventoryDestinationBucket? BucketInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketInventoryDestinationBucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestination\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketInventoryDestination? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketInventoryDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
