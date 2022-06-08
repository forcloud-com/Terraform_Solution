using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiClass(nativeType: typeof(aws.Elastictranscoder.ElastictranscoderPipelineThumbnailConfigOutputReference), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElastictranscoderPipelineThumbnailConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElastictranscoderPipelineThumbnailConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipelineThumbnailConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipelineThumbnailConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBucket")]
        public virtual void ResetBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageClass")]
        public virtual void ResetStorageClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfig\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
