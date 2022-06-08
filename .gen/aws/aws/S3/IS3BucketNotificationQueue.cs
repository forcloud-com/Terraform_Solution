using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketNotificationQueue), fullyQualifiedName: "aws.s3.S3BucketNotificationQueue")]
    public interface IS3BucketNotificationQueue
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#events S3BucketNotification#events}.</summary>
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Events
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#queue_arn S3BucketNotification#queue_arn}.</summary>
        [JsiiProperty(name: "queueArn", typeJson: "{\"primitive\":\"string\"}")]
        string QueueArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#filter_prefix S3BucketNotification#filter_prefix}.</summary>
        [JsiiProperty(name: "filterPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FilterPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#filter_suffix S3BucketNotification#filter_suffix}.</summary>
        [JsiiProperty(name: "filterSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FilterSuffix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#id S3BucketNotification#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketNotificationQueue), fullyQualifiedName: "aws.s3.S3BucketNotificationQueue")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketNotificationQueue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#events S3BucketNotification#events}.</summary>
            [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Events
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#queue_arn S3BucketNotification#queue_arn}.</summary>
            [JsiiProperty(name: "queueArn", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#filter_prefix S3BucketNotification#filter_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filterPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FilterPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#filter_suffix S3BucketNotification#filter_suffix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filterSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FilterSuffix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#id S3BucketNotification#id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
