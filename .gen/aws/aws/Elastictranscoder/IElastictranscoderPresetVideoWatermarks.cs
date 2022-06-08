using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPresetVideoWatermarks), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPresetVideoWatermarks")]
    public interface IElastictranscoderPresetVideoWatermarks
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#horizontal_align ElastictranscoderPreset#horizontal_align}.</summary>
        [JsiiProperty(name: "horizontalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HorizontalAlign
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#horizontal_offset ElastictranscoderPreset#horizontal_offset}.</summary>
        [JsiiProperty(name: "horizontalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HorizontalOffset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#id ElastictranscoderPreset#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#max_height ElastictranscoderPreset#max_height}.</summary>
        [JsiiProperty(name: "maxHeight", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxHeight
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#max_width ElastictranscoderPreset#max_width}.</summary>
        [JsiiProperty(name: "maxWidth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxWidth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#opacity ElastictranscoderPreset#opacity}.</summary>
        [JsiiProperty(name: "opacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Opacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#sizing_policy ElastictranscoderPreset#sizing_policy}.</summary>
        [JsiiProperty(name: "sizingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SizingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#target ElastictranscoderPreset#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#vertical_align ElastictranscoderPreset#vertical_align}.</summary>
        [JsiiProperty(name: "verticalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerticalAlign
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#vertical_offset ElastictranscoderPreset#vertical_offset}.</summary>
        [JsiiProperty(name: "verticalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerticalOffset
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPresetVideoWatermarks), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPresetVideoWatermarks")]
        internal sealed class _Proxy : DeputyBase, aws.Elastictranscoder.IElastictranscoderPresetVideoWatermarks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#horizontal_align ElastictranscoderPreset#horizontal_align}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "horizontalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HorizontalAlign
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#horizontal_offset ElastictranscoderPreset#horizontal_offset}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "horizontalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HorizontalOffset
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#id ElastictranscoderPreset#id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#max_height ElastictranscoderPreset#max_height}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxHeight", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxHeight
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#max_width ElastictranscoderPreset#max_width}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxWidth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxWidth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#opacity ElastictranscoderPreset#opacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Opacity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#sizing_policy ElastictranscoderPreset#sizing_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SizingPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#target ElastictranscoderPreset#target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#vertical_align ElastictranscoderPreset#vertical_align}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verticalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerticalAlign
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_preset#vertical_offset ElastictranscoderPreset#vertical_offset}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verticalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerticalOffset
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
