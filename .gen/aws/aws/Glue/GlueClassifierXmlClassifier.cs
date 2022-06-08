using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueClassifierXmlClassifier")]
    public class GlueClassifierXmlClassifier : aws.Glue.IGlueClassifierXmlClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#classification GlueClassifier#classification}.</summary>
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        public string Classification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#row_tag GlueClassifier#row_tag}.</summary>
        [JsiiProperty(name: "rowTag", typeJson: "{\"primitive\":\"string\"}")]
        public string RowTag
        {
            get;
            set;
        }
    }
}
