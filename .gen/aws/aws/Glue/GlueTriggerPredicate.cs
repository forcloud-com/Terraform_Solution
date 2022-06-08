using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueTriggerPredicate")]
    public class GlueTriggerPredicate : aws.Glue.IGlueTriggerPredicate
    {
        /// <summary>conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#conditions GlueTrigger#conditions}
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}]}}")]
        public object Conditions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#logical GlueTrigger#logical}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Logical
        {
            get;
            set;
        }
    }
}
