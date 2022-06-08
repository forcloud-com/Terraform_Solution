using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    /// <summary>AWS Glue.</summary>
    [JsiiByValue(fqn: "aws.glue.GlueClassifierConfig")]
    public class GlueClassifierConfig : aws.Glue.IGlueClassifierConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#name GlueClassifier#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>csv_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#csv_classifier GlueClassifier#csv_classifier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "csvClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierCsvClassifier\"}", isOptional: true)]
        public aws.Glue.IGlueClassifierCsvClassifier? CsvClassifier
        {
            get;
            set;
        }

        /// <summary>grok_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#grok_classifier GlueClassifier#grok_classifier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grokClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierGrokClassifier\"}", isOptional: true)]
        public aws.Glue.IGlueClassifierGrokClassifier? GrokClassifier
        {
            get;
            set;
        }

        /// <summary>json_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#json_classifier GlueClassifier#json_classifier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jsonClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierJsonClassifier\"}", isOptional: true)]
        public aws.Glue.IGlueClassifierJsonClassifier? JsonClassifier
        {
            get;
            set;
        }

        /// <summary>xml_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#xml_classifier GlueClassifier#xml_classifier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xmlClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierXmlClassifier\"}", isOptional: true)]
        public aws.Glue.IGlueClassifierXmlClassifier? XmlClassifier
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
