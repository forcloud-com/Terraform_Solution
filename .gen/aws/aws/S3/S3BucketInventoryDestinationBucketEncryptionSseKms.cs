using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketInventoryDestinationBucketEncryptionSseKms")]
    public class S3BucketInventoryDestinationBucketEncryptionSseKms : aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseKms
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#key_id S3BucketInventory#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyId
        {
            get;
            set;
        }
    }
}
