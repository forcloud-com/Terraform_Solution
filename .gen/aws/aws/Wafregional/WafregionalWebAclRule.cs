using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregional.WafregionalWebAclRule")]
    public class WafregionalWebAclRule : aws.Wafregional.IWafregionalWebAclRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#priority WafregionalWebAcl#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#rule_id WafregionalWebAcl#rule_id}.</summary>
        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleId
        {
            get;
            set;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#action WafregionalWebAcl#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclRuleAction\"}", isOptional: true)]
        public aws.Wafregional.IWafregionalWebAclRuleAction? Action
        {
            get;
            set;
        }

        /// <summary>override_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#override_action WafregionalWebAcl#override_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclRuleOverrideAction\"}", isOptional: true)]
        public aws.Wafregional.IWafregionalWebAclRuleOverrideAction? OverrideAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#type WafregionalWebAcl#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
