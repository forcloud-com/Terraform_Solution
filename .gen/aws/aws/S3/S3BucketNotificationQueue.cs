using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketNotificationQueue")]
    public class S3BucketNotificationQueue : aws.S3.IS3BucketNotificationQueue
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#events S3BucketNotification#events}.</summary>
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Events
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#queue_arn S3BucketNotification#queue_arn}.</summary>
        [JsiiProperty(name: "queueArn", typeJson: "{\"primitive\":\"string\"}")]
        public string QueueArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#filter_prefix S3BucketNotification#filter_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filterPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilterPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#filter_suffix S3BucketNotification#filter_suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filterSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilterSuffix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#id S3BucketNotification#id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }
    }
}
