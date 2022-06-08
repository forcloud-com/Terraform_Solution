using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiByValue(fqn: "aws.s3.S3BucketLifecycleRuleExpiration")]
    public class S3BucketLifecycleRuleExpiration : aws.S3.IS3BucketLifecycleRuleExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#date S3Bucket#date}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Date
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#days S3Bucket#days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#expired_object_delete_marker S3Bucket#expired_object_delete_marker}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expiredObjectDeleteMarker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ExpiredObjectDeleteMarker
        {
            get;
            set;
        }
    }
}
