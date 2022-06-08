using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregional.WafregionalXssMatchSetXssMatchTupleFieldToMatch")]
    public class WafregionalXssMatchSetXssMatchTupleFieldToMatch : aws.Wafregional.IWafregionalXssMatchSetXssMatchTupleFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_xss_match_set#type WafregionalXssMatchSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_xss_match_set#data WafregionalXssMatchSet#data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Data
        {
            get;
            set;
        }
    }
}
