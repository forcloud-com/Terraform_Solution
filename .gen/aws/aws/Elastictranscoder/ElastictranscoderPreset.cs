using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset aws_elastictranscoder_preset}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elastictranscoder.ElastictranscoderPreset), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPreset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetConfig\"}}]")]
    public class ElastictranscoderPreset : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset aws_elastictranscoder_preset} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElastictranscoderPreset(Constructs.Construct scope, string id, aws.Elastictranscoder.IElastictranscoderPresetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPreset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPreset(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAudio", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudio\"}}]")]
        public virtual void PutAudio(aws.Elastictranscoder.IElastictranscoderPresetAudio @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elastictranscoder.IElastictranscoderPresetAudio)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAudioCodecOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudioCodecOptions\"}}]")]
        public virtual void PutAudioCodecOptions(aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThumbnails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetThumbnails\"}}]")]
        public virtual void PutThumbnails(aws.Elastictranscoder.IElastictranscoderPresetThumbnails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elastictranscoder.IElastictranscoderPresetThumbnails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVideo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideo\"}}]")]
        public virtual void PutVideo(aws.Elastictranscoder.IElastictranscoderPresetVideo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elastictranscoder.IElastictranscoderPresetVideo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAudio")]
        public virtual void ResetAudio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudioCodecOptions")]
        public virtual void ResetAudioCodecOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnails")]
        public virtual void ResetThumbnails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideo")]
        public virtual void ResetVideo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideoCodecOptions")]
        public virtual void ResetVideoCodecOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideoWatermarks")]
        public virtual void ResetVideoWatermarks()
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
        = GetStaticProperty<string>(typeof(aws.Elastictranscoder.ElastictranscoderPreset))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudioOutputReference\"}")]
        public virtual aws.Elastictranscoder.ElastictranscoderPresetAudioOutputReference Audio
        {
            get => GetInstanceProperty<aws.Elastictranscoder.ElastictranscoderPresetAudioOutputReference>()!;
        }

        [JsiiProperty(name: "audioCodecOptions", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudioCodecOptionsOutputReference\"}")]
        public virtual aws.Elastictranscoder.ElastictranscoderPresetAudioCodecOptionsOutputReference AudioCodecOptions
        {
            get => GetInstanceProperty<aws.Elastictranscoder.ElastictranscoderPresetAudioCodecOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thumbnails", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetThumbnailsOutputReference\"}")]
        public virtual aws.Elastictranscoder.ElastictranscoderPresetThumbnailsOutputReference Thumbnails
        {
            get => GetInstanceProperty<aws.Elastictranscoder.ElastictranscoderPresetThumbnailsOutputReference>()!;
        }

        [JsiiProperty(name: "video", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideoOutputReference\"}")]
        public virtual aws.Elastictranscoder.ElastictranscoderPresetVideoOutputReference Video
        {
            get => GetInstanceProperty<aws.Elastictranscoder.ElastictranscoderPresetVideoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioCodecOptionsInput", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudioCodecOptions\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions? AudioCodecOptionsInput
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioInput", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudio\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPresetAudio? AudioInput
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetAudio?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "thumbnailsInput", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetThumbnails\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPresetThumbnails? ThumbnailsInput
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetThumbnails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoCodecOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? VideoCodecOptionsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoInput", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideo\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPresetVideo? VideoInput
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetVideo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoWatermarksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VideoWatermarksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Container
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "videoCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> VideoCodecOptions
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "videoWatermarks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}]}}")]
        public virtual object VideoWatermarks
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
