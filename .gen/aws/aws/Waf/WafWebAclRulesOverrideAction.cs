using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.waf.WafWebAclRulesOverrideAction")]
    public class WafWebAclRulesOverrideAction : aws.Waf.IWafWebAclRulesOverrideAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#type WafWebAcl#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
