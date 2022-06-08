using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    /// <summary>AWS Elastic Transcoder.</summary>
    [JsiiInterface(nativeType: typeof(IElastictranscoderPipelineConfig), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPipelineConfig")]
    public interface IElastictranscoderPipelineConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#input_bucket ElastictranscoderPipeline#input_bucket}.</summary>
        [JsiiProperty(name: "inputBucket", typeJson: "{\"primitive\":\"string\"}")]
        string InputBucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#role ElastictranscoderPipeline#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#aws_kms_key_arn ElastictranscoderPipeline#aws_kms_key_arn}.</summary>
        [JsiiProperty(name: "awsKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsKmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>content_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#content_config ElastictranscoderPipeline#content_config}
        /// </remarks>
        [JsiiProperty(name: "contentConfig", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elastictranscoder.IElastictranscoderPipelineContentConfig? ContentConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>content_config_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#content_config_permissions ElastictranscoderPipeline#content_config_permissions}
        /// </remarks>
        [JsiiProperty(name: "contentConfigPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContentConfigPermissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#name ElastictranscoderPipeline#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#notifications ElastictranscoderPipeline#notifications}
        /// </remarks>
        [JsiiProperty(name: "notifications", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elastictranscoder.IElastictranscoderPipelineNotifications? Notifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#output_bucket ElastictranscoderPipeline#output_bucket}.</summary>
        [JsiiProperty(name: "outputBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputBucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>thumbnail_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#thumbnail_config ElastictranscoderPipeline#thumbnail_config}
        /// </remarks>
        [JsiiProperty(name: "thumbnailConfig", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig? ThumbnailConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>thumbnail_config_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#thumbnail_config_permissions ElastictranscoderPipeline#thumbnail_config_permissions}
        /// </remarks>
        [JsiiProperty(name: "thumbnailConfigPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThumbnailConfigPermissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Elastic Transcoder.</summary>
        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPipelineConfig), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPipelineConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elastictranscoder.IElastictranscoderPipelineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#input_bucket ElastictranscoderPipeline#input_bucket}.</summary>
            [JsiiProperty(name: "inputBucket", typeJson: "{\"primitive\":\"string\"}")]
            public string InputBucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#role ElastictranscoderPipeline#role}.</summary>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#aws_kms_key_arn ElastictranscoderPipeline#aws_kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsKmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>content_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#content_config ElastictranscoderPipeline#content_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentConfig", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfig\"}", isOptional: true)]
            public aws.Elastictranscoder.IElastictranscoderPipelineContentConfig? ContentConfig
            {
                get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPipelineContentConfig?>();
            }

            /// <summary>content_config_permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#content_config_permissions ElastictranscoderPipeline#content_config_permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentConfigPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ContentConfigPermissions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#name ElastictranscoderPipeline#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#notifications ElastictranscoderPipeline#notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notifications", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineNotifications\"}", isOptional: true)]
            public aws.Elastictranscoder.IElastictranscoderPipelineNotifications? Notifications
            {
                get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPipelineNotifications?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#output_bucket ElastictranscoderPipeline#output_bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputBucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>thumbnail_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#thumbnail_config ElastictranscoderPipeline#thumbnail_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thumbnailConfig", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfig\"}", isOptional: true)]
            public aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig? ThumbnailConfig
            {
                get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig?>();
            }

            /// <summary>thumbnail_config_permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#thumbnail_config_permissions ElastictranscoderPipeline#thumbnail_config_permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thumbnailConfigPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThumbnailConfigPermissions
            {
                get => GetInstanceProperty<object?>();
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
