using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueClassifierJsonClassifier")]
    public class GlueClassifierJsonClassifier : aws.Glue.IGlueClassifierJsonClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#json_path GlueClassifier#json_path}.</summary>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        public string JsonPath
        {
            get;
            set;
        }
    }
}
