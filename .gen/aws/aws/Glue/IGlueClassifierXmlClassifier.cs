using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierXmlClassifier), fullyQualifiedName: "aws.glue.GlueClassifierXmlClassifier")]
    public interface IGlueClassifierXmlClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#classification GlueClassifier#classification}.</summary>
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        string Classification
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#row_tag GlueClassifier#row_tag}.</summary>
        [JsiiProperty(name: "rowTag", typeJson: "{\"primitive\":\"string\"}")]
        string RowTag
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierXmlClassifier), fullyQualifiedName: "aws.glue.GlueClassifierXmlClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueClassifierXmlClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#classification GlueClassifier#classification}.</summary>
            [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
            public string Classification
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#row_tag GlueClassifier#row_tag}.</summary>
            [JsiiProperty(name: "rowTag", typeJson: "{\"primitive\":\"string\"}")]
            public string RowTag
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
