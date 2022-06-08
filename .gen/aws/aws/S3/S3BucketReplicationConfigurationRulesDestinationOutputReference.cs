using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketReplicationConfigurationRulesDestinationOutputReference), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketReplicationConfigurationRulesDestinationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketReplicationConfigurationRulesDestinationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRulesDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRulesDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessControlTranslation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"}}]")]
        public virtual void PutAccessControlTranslation(aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessControlTranslation")]
        public virtual void ResetAccessControlTranslation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicaKmsKeyId")]
        public virtual void ResetReplicaKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageClass")]
        public virtual void ResetStorageClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslationOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslationOutputReference AccessControlTranslation
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlTranslationInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation? AccessControlTranslationInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaKmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicaKmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicaKmsKeyId
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestination\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRulesDestination? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRulesDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
