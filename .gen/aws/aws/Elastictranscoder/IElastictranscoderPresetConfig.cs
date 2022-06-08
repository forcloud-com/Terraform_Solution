using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    /// <summary>AWS Elastic Transcoder.</summary>
    [JsiiInterface(nativeType: typeof(IElastictranscoderPresetConfig), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPresetConfig")]
    public interface IElastictranscoderPresetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#container ElastictranscoderPreset#container}.</summary>
        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}")]
        string Container
        {
            get;
        }

        /// <summary>audio block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#audio ElastictranscoderPreset#audio}
        /// </remarks>
        [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudio\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elastictranscoder.IElastictranscoderPresetAudio? Audio
        {
            get
            {
                return null;
            }
        }

        /// <summary>audio_codec_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#audio_codec_options ElastictranscoderPreset#audio_codec_options}
        /// </remarks>
        [JsiiProperty(name: "audioCodecOptions", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudioCodecOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions? AudioCodecOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#description ElastictranscoderPreset#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#name ElastictranscoderPreset#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>thumbnails block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#thumbnails ElastictranscoderPreset#thumbnails}
        /// </remarks>
        [JsiiProperty(name: "thumbnails", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetThumbnails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elastictranscoder.IElastictranscoderPresetThumbnails? Thumbnails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#type ElastictranscoderPreset#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>video block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#video ElastictranscoderPreset#video}
        /// </remarks>
        [JsiiProperty(name: "video", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elastictranscoder.IElastictranscoderPresetVideo? Video
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#video_codec_options ElastictranscoderPreset#video_codec_options}.</summary>
        [JsiiProperty(name: "videoCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? VideoCodecOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>video_watermarks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#video_watermarks ElastictranscoderPreset#video_watermarks}
        /// </remarks>
        [JsiiProperty(name: "videoWatermarks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VideoWatermarks
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Elastic Transcoder.</summary>
        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPresetConfig), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPresetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elastictranscoder.IElastictranscoderPresetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#container ElastictranscoderPreset#container}.</summary>
            [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}")]
            public string Container
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>audio block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#audio ElastictranscoderPreset#audio}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudio\"}", isOptional: true)]
            public aws.Elastictranscoder.IElastictranscoderPresetAudio? Audio
            {
                get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetAudio?>();
            }

            /// <summary>audio_codec_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#audio_codec_options ElastictranscoderPreset#audio_codec_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audioCodecOptions", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudioCodecOptions\"}", isOptional: true)]
            public aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions? AudioCodecOptions
            {
                get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#description ElastictranscoderPreset#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#name ElastictranscoderPreset#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>thumbnails block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#thumbnails ElastictranscoderPreset#thumbnails}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thumbnails", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetThumbnails\"}", isOptional: true)]
            public aws.Elastictranscoder.IElastictranscoderPresetThumbnails? Thumbnails
            {
                get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetThumbnails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#type ElastictranscoderPreset#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>video block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#video ElastictranscoderPreset#video}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "video", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideo\"}", isOptional: true)]
            public aws.Elastictranscoder.IElastictranscoderPresetVideo? Video
            {
                get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetVideo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#video_codec_options ElastictranscoderPreset#video_codec_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "videoCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? VideoCodecOptions
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>video_watermarks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#video_watermarks ElastictranscoderPreset#video_watermarks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "videoWatermarks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VideoWatermarks
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
