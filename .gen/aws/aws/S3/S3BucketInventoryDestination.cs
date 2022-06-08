using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketInventoryDestination")]
    public class S3BucketInventoryDestination : aws.S3.IS3BucketInventoryDestination
    {
        /// <summary>bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#bucket S3BucketInventory#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucket\"}")]
        public aws.S3.IS3BucketInventoryDestinationBucket Bucket
        {
            get;
            set;
        }
    }
}
