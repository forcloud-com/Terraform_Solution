using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault), fullyQualifiedName: "aws.s3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
    public interface IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#sse_algorithm S3Bucket#sse_algorithm}.</summary>
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string SseAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#kms_master_key_id S3Bucket#kms_master_key_id}.</summary>
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsMasterKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault), fullyQualifiedName: "aws.s3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#sse_algorithm S3Bucket#sse_algorithm}.</summary>
            [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string SseAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#kms_master_key_id S3Bucket#kms_master_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsMasterKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
