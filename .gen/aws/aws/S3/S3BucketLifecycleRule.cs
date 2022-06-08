using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketLifecycleRule")]
    public class S3BucketLifecycleRule : aws.S3.IS3BucketLifecycleRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#enabled S3Bucket#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#abort_incomplete_multipart_upload_days S3Bucket#abort_incomplete_multipart_upload_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AbortIncompleteMultipartUploadDays
        {
            get;
            set;
        }

        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#expiration S3Bucket#expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"aws.s3.S3BucketLifecycleRuleExpiration\"}", isOptional: true)]
        public aws.S3.IS3BucketLifecycleRuleExpiration? Expiration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#id S3Bucket#id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>noncurrent_version_expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#noncurrent_version_expiration S3Bucket#noncurrent_version_expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"fqn\":\"aws.s3.S3BucketLifecycleRuleNoncurrentVersionExpiration\"}", isOptional: true)]
        public aws.S3.IS3BucketLifecycleRuleNoncurrentVersionExpiration? NoncurrentVersionExpiration
        {
            get;
            set;
        }

        /// <summary>noncurrent_version_transition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#noncurrent_version_transition S3Bucket#noncurrent_version_transition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionTransition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketLifecycleRuleNoncurrentVersionTransition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NoncurrentVersionTransition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#prefix S3Bucket#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#tags S3Bucket#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>transition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#transition S3Bucket#transition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketLifecycleRuleTransition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Transition
        {
            get;
            set;
        }
    }
}
