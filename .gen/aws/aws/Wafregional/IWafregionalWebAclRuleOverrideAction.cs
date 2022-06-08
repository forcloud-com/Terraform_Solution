using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclRuleOverrideAction), fullyQualifiedName: "aws.wafregional.WafregionalWebAclRuleOverrideAction")]
    public interface IWafregionalWebAclRuleOverrideAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#type WafregionalWebAcl#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclRuleOverrideAction), fullyQualifiedName: "aws.wafregional.WafregionalWebAclRuleOverrideAction")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalWebAclRuleOverrideAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#type WafregionalWebAcl#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
