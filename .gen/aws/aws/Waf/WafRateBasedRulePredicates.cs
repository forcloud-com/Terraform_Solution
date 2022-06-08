using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.waf.WafRateBasedRulePredicates")]
    public class WafRateBasedRulePredicates : aws.Waf.IWafRateBasedRulePredicates
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule#data_id WafRateBasedRule#data_id}.</summary>
        [JsiiProperty(name: "dataId", typeJson: "{\"primitive\":\"string\"}")]
        public string DataId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule#negated WafRateBasedRule#negated}.</summary>
        [JsiiProperty(name: "negated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Negated
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule#type WafRateBasedRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
