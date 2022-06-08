using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleAction")]
    public class Wafv2WebAclRuleAction : aws.Wafv2.IWafv2WebAclRuleAction
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#allow Wafv2WebAcl#allow}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionAllow\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleActionAllow? Allow
        {
            get;
            set;
        }

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#block Wafv2WebAcl#block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionBlock\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleActionBlock? Block
        {
            get;
            set;
        }

        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#count Wafv2WebAcl#count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCount\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleActionCount? Count
        {
            get;
            set;
        }
    }
}
