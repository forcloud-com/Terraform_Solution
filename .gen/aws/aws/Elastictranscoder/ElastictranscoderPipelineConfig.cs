using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    #pragma warning disable CS8618

    /// <summary>AWS Elastic Transcoder.</summary>
    [JsiiByValue(fqn: "aws.elastictranscoder.ElastictranscoderPipelineConfig")]
    public class ElastictranscoderPipelineConfig : aws.Elastictranscoder.IElastictranscoderPipelineConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#input_bucket ElastictranscoderPipeline#input_bucket}.</summary>
        [JsiiProperty(name: "inputBucket", typeJson: "{\"primitive\":\"string\"}")]
        public string InputBucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#role ElastictranscoderPipeline#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public string Role
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#aws_kms_key_arn ElastictranscoderPipeline#aws_kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AwsKmsKeyArn
        {
            get;
            set;
        }

        /// <summary>content_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#content_config ElastictranscoderPipeline#content_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentConfig", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfig\"}", isOptional: true)]
        public aws.Elastictranscoder.IElastictranscoderPipelineContentConfig? ContentConfig
        {
            get;
            set;
        }

        /// <summary>content_config_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#content_config_permissions ElastictranscoderPipeline#content_config_permissions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentConfigPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ContentConfigPermissions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#name ElastictranscoderPipeline#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#notifications ElastictranscoderPipeline#notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notifications", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineNotifications\"}", isOptional: true)]
        public aws.Elastictranscoder.IElastictranscoderPipelineNotifications? Notifications
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#output_bucket ElastictranscoderPipeline#output_bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputBucket
        {
            get;
            set;
        }

        /// <summary>thumbnail_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#thumbnail_config ElastictranscoderPipeline#thumbnail_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfig", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfig\"}", isOptional: true)]
        public aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig? ThumbnailConfig
        {
            get;
            set;
        }

        /// <summary>thumbnail_config_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#thumbnail_config_permissions ElastictranscoderPipeline#thumbnail_config_permissions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfigPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThumbnailConfigPermissions
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
