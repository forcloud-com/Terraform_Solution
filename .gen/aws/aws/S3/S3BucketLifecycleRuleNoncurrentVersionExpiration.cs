using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiByValue(fqn: "aws.s3.S3BucketLifecycleRuleNoncurrentVersionExpiration")]
    public class S3BucketLifecycleRuleNoncurrentVersionExpiration : aws.S3.IS3BucketLifecycleRuleNoncurrentVersionExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#days S3Bucket#days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }
    }
}
