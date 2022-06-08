using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierCsvClassifier), fullyQualifiedName: "aws.glue.GlueClassifierCsvClassifier")]
    public interface IGlueClassifierCsvClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#allow_single_column GlueClassifier#allow_single_column}.</summary>
        [JsiiProperty(name: "allowSingleColumn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowSingleColumn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#contains_header GlueClassifier#contains_header}.</summary>
        [JsiiProperty(name: "containsHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainsHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#delimiter GlueClassifier#delimiter}.</summary>
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delimiter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#disable_value_trimming GlueClassifier#disable_value_trimming}.</summary>
        [JsiiProperty(name: "disableValueTrimming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableValueTrimming
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#header GlueClassifier#header}.</summary>
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#quote_symbol GlueClassifier#quote_symbol}.</summary>
        [JsiiProperty(name: "quoteSymbol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QuoteSymbol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierCsvClassifier), fullyQualifiedName: "aws.glue.GlueClassifierCsvClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueClassifierCsvClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#allow_single_column GlueClassifier#allow_single_column}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowSingleColumn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowSingleColumn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#contains_header GlueClassifier#contains_header}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containsHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainsHeader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#delimiter GlueClassifier#delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delimiter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#disable_value_trimming GlueClassifier#disable_value_trimming}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableValueTrimming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableValueTrimming
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#header GlueClassifier#header}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Header
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#quote_symbol GlueClassifier#quote_symbol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "quoteSymbol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QuoteSymbol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
