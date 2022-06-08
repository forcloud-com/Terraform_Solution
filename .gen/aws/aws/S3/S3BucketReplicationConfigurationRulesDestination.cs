using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRulesDestination")]
    public class S3BucketReplicationConfigurationRulesDestination : aws.S3.IS3BucketReplicationConfigurationRulesDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#bucket S3Bucket#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>access_control_translation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#access_control_translation S3Bucket#access_control_translation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"}", isOptional: true)]
        public aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation? AccessControlTranslation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#account_id S3Bucket#account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#replica_kms_key_id S3Bucket#replica_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicaKmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#storage_class S3Bucket#storage_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageClass
        {
            get;
            set;
        }
    }
}
