using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiByValue(fqn: "aws.elastictranscoder.ElastictranscoderPresetAudioCodecOptions")]
    public class ElastictranscoderPresetAudioCodecOptions : aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#bit_depth ElastictranscoderPreset#bit_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bitDepth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BitDepth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#bit_order ElastictranscoderPreset#bit_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bitOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BitOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#profile ElastictranscoderPreset#profile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Profile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#signed ElastictranscoderPreset#signed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Signed
        {
            get;
            set;
        }
    }
}
