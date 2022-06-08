using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafWebAclRules), fullyQualifiedName: "aws.waf.WafWebAclRules")]
    public interface IWafWebAclRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#priority WafWebAcl#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#rule_id WafWebAcl#rule_id}.</summary>
        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        string RuleId
        {
            get;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#action WafWebAcl#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.waf.WafWebAclRulesAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Waf.IWafWebAclRulesAction? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>override_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#override_action WafWebAcl#override_action}
        /// </remarks>
        [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.waf.WafWebAclRulesOverrideAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Waf.IWafWebAclRulesOverrideAction? OverrideAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#type WafWebAcl#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAclRules), fullyQualifiedName: "aws.waf.WafWebAclRules")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafWebAclRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#priority WafWebAcl#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#rule_id WafWebAcl#rule_id}.</summary>
            [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#action WafWebAcl#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.waf.WafWebAclRulesAction\"}", isOptional: true)]
            public aws.Waf.IWafWebAclRulesAction? Action
            {
                get => GetInstanceProperty<aws.Waf.IWafWebAclRulesAction?>();
            }

            /// <summary>override_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#override_action WafWebAcl#override_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.waf.WafWebAclRulesOverrideAction\"}", isOptional: true)]
            public aws.Waf.IWafWebAclRulesOverrideAction? OverrideAction
            {
                get => GetInstanceProperty<aws.Waf.IWafWebAclRulesOverrideAction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#type WafWebAcl#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
