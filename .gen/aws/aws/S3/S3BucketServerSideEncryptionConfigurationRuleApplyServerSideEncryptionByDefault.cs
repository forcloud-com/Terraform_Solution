using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
    public class S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault : aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#sse_algorithm S3Bucket#sse_algorithm}.</summary>
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string SseAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#kms_master_key_id S3Bucket#kms_master_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsMasterKeyId
        {
            get;
            set;
        }
    }
}
