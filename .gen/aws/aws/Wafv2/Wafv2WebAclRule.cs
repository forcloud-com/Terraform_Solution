using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRule")]
    public class Wafv2WebAclRule : aws.Wafv2.IWafv2WebAclRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#priority Wafv2WebAcl#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatement\"}")]
        public aws.Wafv2.IWafv2WebAclRuleStatement Statement
        {
            get;
            set;
        }

        /// <summary>visibility_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#visibility_config Wafv2WebAcl#visibility_config}
        /// </remarks>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleVisibilityConfig\"}")]
        public aws.Wafv2.IWafv2WebAclRuleVisibilityConfig VisibilityConfig
        {
            get;
            set;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#action Wafv2WebAcl#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleAction\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleAction? Action
        {
            get;
            set;
        }

        /// <summary>override_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#override_action Wafv2WebAcl#override_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideAction\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleOverrideAction? OverrideAction
        {
            get;
            set;
        }
    }
}
