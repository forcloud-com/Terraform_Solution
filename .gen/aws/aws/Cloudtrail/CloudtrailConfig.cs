using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudtrail
{
    #pragma warning disable CS8618

    /// <summary>AWS CloudTrail.</summary>
    [JsiiByValue(fqn: "aws.cloudtrail.CloudtrailConfig")]
    public class CloudtrailConfig : aws.Cloudtrail.ICloudtrailConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#name Cloudtrail#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#s3_bucket_name Cloudtrail#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string S3BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#cloud_watch_logs_group_arn Cloudtrail#cloud_watch_logs_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchLogsGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudWatchLogsGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#cloud_watch_logs_role_arn Cloudtrail#cloud_watch_logs_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudWatchLogsRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#enable_log_file_validation Cloudtrail#enable_log_file_validation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableLogFileValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableLogFileValidation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#enable_logging Cloudtrail#enable_logging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableLogging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableLogging
        {
            get;
            set;
        }

        /// <summary>event_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#event_selector Cloudtrail#event_selector}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailEventSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EventSelector
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#include_global_service_events Cloudtrail#include_global_service_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeGlobalServiceEvents", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeGlobalServiceEvents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#is_multi_region_trail Cloudtrail#is_multi_region_trail}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isMultiRegionTrail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IsMultiRegionTrail
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#is_organization_trail Cloudtrail#is_organization_trail}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isOrganizationTrail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IsOrganizationTrail
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#kms_key_id Cloudtrail#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#s3_key_prefix Cloudtrail#s3_key_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3KeyPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#sns_topic_name Cloudtrail#sns_topic_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snsTopicName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnsTopicName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#tags Cloudtrail#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
