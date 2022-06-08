using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiByValue(fqn: "aws.s3.S3BucketInventoryDestinationBucketEncryption")]
    public class S3BucketInventoryDestinationBucketEncryption : aws.S3.IS3BucketInventoryDestinationBucketEncryption
    {
        /// <summary>sse_kms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#sse_kms S3BucketInventory#sse_kms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sseKms", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketEncryptionSseKms\"}", isOptional: true)]
        public aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseKms? SseKms
        {
            get;
            set;
        }

        /// <summary>sse_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#sse_s3 S3BucketInventory#sse_s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sseS3", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucketEncryptionSseS3\"}", isOptional: true)]
        public aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseS3? SseS3
        {
            get;
            set;
        }
    }
}
