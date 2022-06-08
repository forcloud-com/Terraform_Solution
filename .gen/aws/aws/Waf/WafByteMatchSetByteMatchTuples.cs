using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.waf.WafByteMatchSetByteMatchTuples")]
    public class WafByteMatchSetByteMatchTuples : aws.Waf.IWafByteMatchSetByteMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_byte_match_set#field_to_match WafByteMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafByteMatchSetByteMatchTuplesFieldToMatch\"}")]
        public aws.Waf.IWafByteMatchSetByteMatchTuplesFieldToMatch FieldToMatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_byte_match_set#positional_constraint WafByteMatchSet#positional_constraint}.</summary>
        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public string PositionalConstraint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_byte_match_set#text_transformation WafByteMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        public string TextTransformation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_byte_match_set#target_string WafByteMatchSet#target_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetString
        {
            get;
            set;
        }
    }
}
