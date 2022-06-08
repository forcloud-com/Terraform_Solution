using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.waf.WafRegexMatchSetRegexMatchTuple")]
    public class WafRegexMatchSetRegexMatchTuple : aws.Waf.IWafRegexMatchSetRegexMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#field_to_match WafRegexMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafRegexMatchSetRegexMatchTupleFieldToMatch\"}")]
        public aws.Waf.IWafRegexMatchSetRegexMatchTupleFieldToMatch FieldToMatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#regex_pattern_set_id WafRegexMatchSet#regex_pattern_set_id}.</summary>
        [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
        public string RegexPatternSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#text_transformation WafRegexMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        public string TextTransformation
        {
            get;
            set;
        }
    }
}
