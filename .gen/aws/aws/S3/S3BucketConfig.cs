using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>AWS Simple Storage Service.</summary>
    [JsiiByValue(fqn: "aws.s3.S3BucketConfig")]
    public class S3BucketConfig : aws.S3.IS3BucketConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#acceleration_status S3Bucket#acceleration_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accelerationStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccelerationStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#acl S3Bucket#acl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Acl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#arn S3Bucket#arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#bucket S3Bucket#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#bucket_prefix S3Bucket#bucket_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketPrefix
        {
            get;
            set;
        }

        /// <summary>cors_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#cors_rule S3Bucket#cors_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CorsRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#force_destroy S3Bucket#force_destroy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForceDestroy
        {
            get;
            set;
        }

        /// <summary>grant block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#grant S3Bucket#grant}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grant", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Grant
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#hosted_zone_id S3Bucket#hosted_zone_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostedZoneId
        {
            get;
            set;
        }

        /// <summary>lifecycle_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#lifecycle_rule S3Bucket#lifecycle_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketLifecycleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LifecycleRule
        {
            get;
            set;
        }

        /// <summary>logging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#logging S3Bucket#logging}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logging", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketLogging\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Logging
        {
            get;
            set;
        }

        /// <summary>object_lock_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#object_lock_configuration S3Bucket#object_lock_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objectLockConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3BucketObjectLockConfiguration\"}", isOptional: true)]
        public aws.S3.IS3BucketObjectLockConfiguration? ObjectLockConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#policy S3Bucket#policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Policy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#region S3Bucket#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>replication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#replication_configuration S3Bucket#replication_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicationConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfiguration\"}", isOptional: true)]
        public aws.S3.IS3BucketReplicationConfiguration? ReplicationConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#request_payer S3Bucket#request_payer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestPayer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestPayer
        {
            get;
            set;
        }

        /// <summary>server_side_encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#server_side_encryption_configuration S3Bucket#server_side_encryption_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfiguration\"}", isOptional: true)]
        public aws.S3.IS3BucketServerSideEncryptionConfiguration? ServerSideEncryptionConfiguration
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

        /// <summary>versioning block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#versioning S3Bucket#versioning}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "versioning", typeJson: "{\"fqn\":\"aws.s3.S3BucketVersioning\"}", isOptional: true)]
        public aws.S3.IS3BucketVersioning? Versioning
        {
            get;
            set;
        }

        /// <summary>website block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#website S3Bucket#website}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "website", typeJson: "{\"fqn\":\"aws.s3.S3BucketWebsite\"}", isOptional: true)]
        public aws.S3.IS3BucketWebsite? Website
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#website_domain S3Bucket#website_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "websiteDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebsiteDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#website_endpoint S3Bucket#website_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "websiteEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebsiteEndpoint
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
