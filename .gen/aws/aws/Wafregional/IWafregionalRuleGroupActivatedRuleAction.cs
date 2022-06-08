using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.wafregional.WafregionalRuleGroupActivatedRuleAction")]
    public interface IWafregionalRuleGroupActivatedRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#type WafregionalRuleGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.wafregional.WafregionalRuleGroupActivatedRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalRuleGroupActivatedRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_rule_group#type WafregionalRuleGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
