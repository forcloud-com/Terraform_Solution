using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RegexPatternSetRegularExpression")]
    public class Wafv2RegexPatternSetRegularExpression : aws.Wafv2.IWafv2RegexPatternSetRegularExpression
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_regex_pattern_set#regex_string Wafv2RegexPatternSet#regex_string}.</summary>
        [JsiiProperty(name: "regexString", typeJson: "{\"primitive\":\"string\"}")]
        public string RegexString
        {
            get;
            set;
        }
    }
}
