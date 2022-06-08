using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueClassifierCsvClassifier")]
    public class GlueClassifierCsvClassifier : aws.Glue.IGlueClassifierCsvClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#allow_single_column GlueClassifier#allow_single_column}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowSingleColumn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowSingleColumn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#contains_header GlueClassifier#contains_header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containsHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainsHeader
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#delimiter GlueClassifier#delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#disable_value_trimming GlueClassifier#disable_value_trimming}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableValueTrimming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DisableValueTrimming
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#header GlueClassifier#header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Header
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#quote_symbol GlueClassifier#quote_symbol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "quoteSymbol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QuoteSymbol
        {
            get;
            set;
        }
    }
}
