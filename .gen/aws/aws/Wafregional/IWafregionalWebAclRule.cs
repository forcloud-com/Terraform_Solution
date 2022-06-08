using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclRule), fullyQualifiedName: "aws.wafregional.WafregionalWebAclRule")]
    public interface IWafregionalWebAclRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#priority WafregionalWebAcl#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#rule_id WafregionalWebAcl#rule_id}.</summary>
        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        string RuleId
        {
            get;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#action WafregionalWebAcl#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclRuleAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafregional.IWafregionalWebAclRuleAction? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>override_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#override_action WafregionalWebAcl#override_action}
        /// </remarks>
        [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclRuleOverrideAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafregional.IWafregionalWebAclRuleOverrideAction? OverrideAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#type WafregionalWebAcl#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclRule), fullyQualifiedName: "aws.wafregional.WafregionalWebAclRule")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalWebAclRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#priority WafregionalWebAcl#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#rule_id WafregionalWebAcl#rule_id}.</summary>
            [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#action WafregionalWebAcl#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclRuleAction\"}", isOptional: true)]
            public aws.Wafregional.IWafregionalWebAclRuleAction? Action
            {
                get => GetInstanceProperty<aws.Wafregional.IWafregionalWebAclRuleAction?>();
            }

            /// <summary>override_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#override_action WafregionalWebAcl#override_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclRuleOverrideAction\"}", isOptional: true)]
            public aws.Wafregional.IWafregionalWebAclRuleOverrideAction? OverrideAction
            {
                get => GetInstanceProperty<aws.Wafregional.IWafregionalWebAclRuleOverrideAction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#type WafregionalWebAcl#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
