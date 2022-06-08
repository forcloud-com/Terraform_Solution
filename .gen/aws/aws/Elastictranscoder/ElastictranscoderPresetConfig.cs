using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    #pragma warning disable CS8618

    /// <summary>AWS Elastic Transcoder.</summary>
    [JsiiByValue(fqn: "aws.elastictranscoder.ElastictranscoderPresetConfig")]
    public class ElastictranscoderPresetConfig : aws.Elastictranscoder.IElastictranscoderPresetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#container ElastictranscoderPreset#container}.</summary>
        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}")]
        public string Container
        {
            get;
            set;
        }

        /// <summary>audio block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#audio ElastictranscoderPreset#audio}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudio\"}", isOptional: true)]
        public aws.Elastictranscoder.IElastictranscoderPresetAudio? Audio
        {
            get;
            set;
        }

        /// <summary>audio_codec_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#audio_codec_options ElastictranscoderPreset#audio_codec_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audioCodecOptions", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudioCodecOptions\"}", isOptional: true)]
        public aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions? AudioCodecOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#description ElastictranscoderPreset#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#name ElastictranscoderPreset#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>thumbnails block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#thumbnails ElastictranscoderPreset#thumbnails}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "thumbnails", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetThumbnails\"}", isOptional: true)]
        public aws.Elastictranscoder.IElastictranscoderPresetThumbnails? Thumbnails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#type ElastictranscoderPreset#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>video block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#video ElastictranscoderPreset#video}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "video", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideo\"}", isOptional: true)]
        public aws.Elastictranscoder.IElastictranscoderPresetVideo? Video
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#video_codec_options ElastictranscoderPreset#video_codec_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "videoCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? VideoCodecOptions
        {
            get;
            set;
        }

        /// <summary>video_watermarks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#video_watermarks ElastictranscoderPreset#video_watermarks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "videoWatermarks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VideoWatermarks
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
