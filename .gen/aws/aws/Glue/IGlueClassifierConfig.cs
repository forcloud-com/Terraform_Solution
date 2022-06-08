using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>AWS Glue.</summary>
    [JsiiInterface(nativeType: typeof(IGlueClassifierConfig), fullyQualifiedName: "aws.glue.GlueClassifierConfig")]
    public interface IGlueClassifierConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#name GlueClassifier#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>csv_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#csv_classifier GlueClassifier#csv_classifier}
        /// </remarks>
        [JsiiProperty(name: "csvClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierCsvClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueClassifierCsvClassifier? CsvClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>grok_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#grok_classifier GlueClassifier#grok_classifier}
        /// </remarks>
        [JsiiProperty(name: "grokClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierGrokClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueClassifierGrokClassifier? GrokClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>json_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#json_classifier GlueClassifier#json_classifier}
        /// </remarks>
        [JsiiProperty(name: "jsonClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierJsonClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueClassifierJsonClassifier? JsonClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>xml_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#xml_classifier GlueClassifier#xml_classifier}
        /// </remarks>
        [JsiiProperty(name: "xmlClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierXmlClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueClassifierXmlClassifier? XmlClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Glue.</summary>
        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierConfig), fullyQualifiedName: "aws.glue.GlueClassifierConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueClassifierConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#name GlueClassifier#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>csv_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#csv_classifier GlueClassifier#csv_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csvClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierCsvClassifier\"}", isOptional: true)]
            public aws.Glue.IGlueClassifierCsvClassifier? CsvClassifier
            {
                get => GetInstanceProperty<aws.Glue.IGlueClassifierCsvClassifier?>();
            }

            /// <summary>grok_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#grok_classifier GlueClassifier#grok_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grokClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierGrokClassifier\"}", isOptional: true)]
            public aws.Glue.IGlueClassifierGrokClassifier? GrokClassifier
            {
                get => GetInstanceProperty<aws.Glue.IGlueClassifierGrokClassifier?>();
            }

            /// <summary>json_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#json_classifier GlueClassifier#json_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jsonClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierJsonClassifier\"}", isOptional: true)]
            public aws.Glue.IGlueClassifierJsonClassifier? JsonClassifier
            {
                get => GetInstanceProperty<aws.Glue.IGlueClassifierJsonClassifier?>();
            }

            /// <summary>xml_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#xml_classifier GlueClassifier#xml_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xmlClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierXmlClassifier\"}", isOptional: true)]
            public aws.Glue.IGlueClassifierXmlClassifier? XmlClassifier
            {
                get => GetInstanceProperty<aws.Glue.IGlueClassifierXmlClassifier?>();
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
