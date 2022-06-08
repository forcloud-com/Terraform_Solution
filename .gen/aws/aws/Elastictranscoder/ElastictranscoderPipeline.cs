using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline aws_elastictranscoder_pipeline}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elastictranscoder.ElastictranscoderPipeline), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPipeline", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineConfig\"}}]")]
    public class ElastictranscoderPipeline : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline aws_elastictranscoder_pipeline} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElastictranscoderPipeline(Constructs.Construct scope, string id, aws.Elastictranscoder.IElastictranscoderPipelineConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipeline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipeline(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContentConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfig\"}}]")]
        public virtual void PutContentConfig(aws.Elastictranscoder.IElastictranscoderPipelineContentConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elastictranscoder.IElastictranscoderPipelineContentConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineNotifications\"}}]")]
        public virtual void PutNotifications(aws.Elastictranscoder.IElastictranscoderPipelineNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elastictranscoder.IElastictranscoderPipelineNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThumbnailConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfig\"}}]")]
        public virtual void PutThumbnailConfig(aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsKmsKeyArn")]
        public virtual void ResetAwsKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentConfig")]
        public virtual void ResetContentConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentConfigPermissions")]
        public virtual void ResetContentConfigPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotifications")]
        public virtual void ResetNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputBucket")]
        public virtual void ResetOutputBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnailConfig")]
        public virtual void ResetThumbnailConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnailConfigPermissions")]
        public virtual void ResetThumbnailConfigPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Elastictranscoder.ElastictranscoderPipeline))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contentConfig", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfigOutputReference\"}")]
        public virtual aws.Elastictranscoder.ElastictranscoderPipelineContentConfigOutputReference ContentConfig
        {
            get => GetInstanceProperty<aws.Elastictranscoder.ElastictranscoderPipelineContentConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notifications", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineNotificationsOutputReference\"}")]
        public virtual aws.Elastictranscoder.ElastictranscoderPipelineNotificationsOutputReference Notifications
        {
            get => GetInstanceProperty<aws.Elastictranscoder.ElastictranscoderPipelineNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "thumbnailConfig", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfigOutputReference\"}")]
        public virtual aws.Elastictranscoder.ElastictranscoderPipelineThumbnailConfigOutputReference ThumbnailConfig
        {
            get => GetInstanceProperty<aws.Elastictranscoder.ElastictranscoderPipelineThumbnailConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsKmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsKmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentConfigInput", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfig\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPipelineContentConfig? ContentConfigInput
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPipelineContentConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentConfigPermissionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContentConfigPermissionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputBucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputBucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationsInput", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineNotifications\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPipelineNotifications? NotificationsInput
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPipelineNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputBucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputBucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfigInput", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfig\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig? ThumbnailConfigInput
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfigPermissionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThumbnailConfigPermissionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "awsKmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsKmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentConfigPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}]}}")]
        public virtual object ContentConfigPermissions
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputBucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputBucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputBucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputBucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thumbnailConfigPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}]}}")]
        public virtual object ThumbnailConfigPermissions
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
