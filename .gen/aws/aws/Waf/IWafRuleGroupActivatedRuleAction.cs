using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.waf.WafRuleGroupActivatedRuleAction")]
    public interface IWafRuleGroupActivatedRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#type WafRuleGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.waf.WafRuleGroupActivatedRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafRuleGroupActivatedRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_rule_group#type WafRuleGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
