using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregional.WafregionalWebAclRuleOverrideAction")]
    public class WafregionalWebAclRuleOverrideAction : aws.Wafregional.IWafregionalWebAclRuleOverrideAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#type WafregionalWebAcl#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
