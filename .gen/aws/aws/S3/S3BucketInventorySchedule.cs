using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketInventorySchedule")]
    public class S3BucketInventorySchedule : aws.S3.IS3BucketInventorySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#frequency S3BucketInventory#frequency}.</summary>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        public string Frequency
        {
            get;
            set;
        }
    }
}
