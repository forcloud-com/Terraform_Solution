using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.waf.WafRegexMatchSetRegexMatchTupleFieldToMatch")]
    public class WafRegexMatchSetRegexMatchTupleFieldToMatch : aws.Waf.IWafRegexMatchSetRegexMatchTupleFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#type WafRegexMatchSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#data WafRegexMatchSet#data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Data
        {
            get;
            set;
        }
    }
}
