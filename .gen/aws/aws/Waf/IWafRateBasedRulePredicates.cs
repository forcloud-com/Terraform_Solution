using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafRateBasedRulePredicates), fullyQualifiedName: "aws.waf.WafRateBasedRulePredicates")]
    public interface IWafRateBasedRulePredicates
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule#data_id WafRateBasedRule#data_id}.</summary>
        [JsiiProperty(name: "dataId", typeJson: "{\"primitive\":\"string\"}")]
        string DataId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule#negated WafRateBasedRule#negated}.</summary>
        [JsiiProperty(name: "negated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Negated
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule#type WafRateBasedRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafRateBasedRulePredicates), fullyQualifiedName: "aws.waf.WafRateBasedRulePredicates")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafRateBasedRulePredicates
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule#data_id WafRateBasedRule#data_id}.</summary>
            [JsiiProperty(name: "dataId", typeJson: "{\"primitive\":\"string\"}")]
            public string DataId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule#negated WafRateBasedRule#negated}.</summary>
            [JsiiProperty(name: "negated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Negated
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule#type WafRateBasedRule#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
