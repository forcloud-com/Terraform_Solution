using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudtrail
{
    /// <summary>AWS CloudTrail.</summary>
    [JsiiInterface(nativeType: typeof(ICloudtrailConfig), fullyQualifiedName: "aws.cloudtrail.CloudtrailConfig")]
    public interface ICloudtrailConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#name Cloudtrail#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#s3_bucket_name Cloudtrail#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        string S3BucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#cloud_watch_logs_group_arn Cloudtrail#cloud_watch_logs_group_arn}.</summary>
        [JsiiProperty(name: "cloudWatchLogsGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudWatchLogsGroupArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#cloud_watch_logs_role_arn Cloudtrail#cloud_watch_logs_role_arn}.</summary>
        [JsiiProperty(name: "cloudWatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudWatchLogsRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#enable_log_file_validation Cloudtrail#enable_log_file_validation}.</summary>
        [JsiiProperty(name: "enableLogFileValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableLogFileValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#enable_logging Cloudtrail#enable_logging}.</summary>
        [JsiiProperty(name: "enableLogging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableLogging
        {
            get
            {
                return null;
            }
        }

        /// <summary>event_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#event_selector Cloudtrail#event_selector}
        /// </remarks>
        [JsiiProperty(name: "eventSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailEventSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EventSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#include_global_service_events Cloudtrail#include_global_service_events}.</summary>
        [JsiiProperty(name: "includeGlobalServiceEvents", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeGlobalServiceEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#is_multi_region_trail Cloudtrail#is_multi_region_trail}.</summary>
        [JsiiProperty(name: "isMultiRegionTrail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMultiRegionTrail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#is_organization_trail Cloudtrail#is_organization_trail}.</summary>
        [JsiiProperty(name: "isOrganizationTrail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsOrganizationTrail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#kms_key_id Cloudtrail#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#s3_key_prefix Cloudtrail#s3_key_prefix}.</summary>
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3KeyPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#sns_topic_name Cloudtrail#sns_topic_name}.</summary>
        [JsiiProperty(name: "snsTopicName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnsTopicName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#tags Cloudtrail#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CloudTrail.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICloudtrailConfig), fullyQualifiedName: "aws.cloudtrail.CloudtrailConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudtrail.ICloudtrailConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#name Cloudtrail#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#s3_bucket_name Cloudtrail#s3_bucket_name}.</summary>
            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string S3BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#cloud_watch_logs_group_arn Cloudtrail#cloud_watch_logs_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudWatchLogsGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudWatchLogsGroupArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#cloud_watch_logs_role_arn Cloudtrail#cloud_watch_logs_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudWatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudWatchLogsRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#enable_log_file_validation Cloudtrail#enable_log_file_validation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableLogFileValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableLogFileValidation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#enable_logging Cloudtrail#enable_logging}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableLogging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableLogging
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>event_selector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#event_selector Cloudtrail#event_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailEventSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EventSelector
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#include_global_service_events Cloudtrail#include_global_service_events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeGlobalServiceEvents", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeGlobalServiceEvents
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#is_multi_region_trail Cloudtrail#is_multi_region_trail}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMultiRegionTrail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsMultiRegionTrail
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#is_organization_trail Cloudtrail#is_organization_trail}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isOrganizationTrail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsOrganizationTrail
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#kms_key_id Cloudtrail#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#s3_key_prefix Cloudtrail#s3_key_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#sns_topic_name Cloudtrail#sns_topic_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snsTopicName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnsTopicName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#tags Cloudtrail#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
