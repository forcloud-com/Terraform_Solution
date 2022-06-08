using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketInventoryDestinationBucketEncryptionOutputReference), fullyQualifiedName: "aws.s3.S3BucketInventoryDestinationBucketEncryptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketInventoryDestinationBucketEncryptionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketInventoryDestinationBucketEncryptionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketInventoryDestinationBucketEncryptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketInventoryDestinationBucketEncryptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSseKms", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketEncryptionSseKms\"}}]")]
        public virtual void PutSseKms(aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseKms @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseKms)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSseS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketEncryptionSseS3\"}}]")]
        public virtual void PutSseS3(aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSseKms")]
        public virtual void ResetSseKms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSseS3")]
        public virtual void ResetSseS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sseKms", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketEncryptionSseKmsOutputReference\"}")]
        public virtual aws.S3.S3BucketInventoryDestinationBucketEncryptionSseKmsOutputReference SseKms
        {
            get => GetInstanceProperty<aws.S3.S3BucketInventoryDestinationBucketEncryptionSseKmsOutputReference>()!;
        }

        [JsiiProperty(name: "sseS3", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketEncryptionSseS3OutputReference\"}")]
        public virtual aws.S3.S3BucketInventoryDestinationBucketEncryptionSseS3OutputReference SseS3
        {
            get => GetInstanceProperty<aws.S3.S3BucketInventoryDestinationBucketEncryptionSseS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseKmsInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketEncryptionSseKms\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseKms? SseKmsInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseKms?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseS3Input", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketEncryptionSseS3\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseS3? SseS3Input
        {
            get => GetInstanceProperty<aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketEncryption\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketInventoryDestinationBucketEncryption? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketInventoryDestinationBucketEncryption?>();
            set => SetInstanceProperty(value);
        }
    }
}
