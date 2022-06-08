using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRulesDestination), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesDestination")]
    public interface IS3BucketReplicationConfigurationRulesDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#bucket S3Bucket#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>access_control_translation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#access_control_translation S3Bucket#access_control_translation}
        /// </remarks>
        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation? AccessControlTranslation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#account_id S3Bucket#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#replica_kms_key_id S3Bucket#replica_kms_key_id}.</summary>
        [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicaKmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#storage_class S3Bucket#storage_class}.</summary>
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageClass
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRulesDestination), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesDestination")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRulesDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#bucket S3Bucket#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>access_control_translation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#access_control_translation S3Bucket#access_control_translation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation? AccessControlTranslation
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#account_id S3Bucket#account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#replica_kms_key_id S3Bucket#replica_kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicaKmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#storage_class S3Bucket#storage_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageClass
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
