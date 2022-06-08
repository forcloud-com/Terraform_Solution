using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregional.WafregionalRateBasedRulePredicate")]
    public class WafregionalRateBasedRulePredicate : aws.Wafregional.IWafregionalRateBasedRulePredicate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rate_based_rule#data_id WafregionalRateBasedRule#data_id}.</summary>
        [JsiiProperty(name: "dataId", typeJson: "{\"primitive\":\"string\"}")]
        public string DataId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rate_based_rule#negated WafregionalRateBasedRule#negated}.</summary>
        [JsiiProperty(name: "negated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Negated
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rate_based_rule#type WafregionalRateBasedRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
