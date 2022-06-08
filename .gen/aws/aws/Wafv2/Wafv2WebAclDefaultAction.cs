using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclDefaultAction")]
    public class Wafv2WebAclDefaultAction : aws.Wafv2.IWafv2WebAclDefaultAction
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#allow Wafv2WebAcl#allow}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllow\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclDefaultActionAllow? Allow
        {
            get;
            set;
        }

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#block Wafv2WebAcl#block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlock\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclDefaultActionBlock? Block
        {
            get;
            set;
        }
    }
}
