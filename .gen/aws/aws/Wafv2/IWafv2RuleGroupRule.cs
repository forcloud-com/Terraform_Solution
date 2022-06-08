using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRule), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRule")]
    public interface IWafv2RuleGroupRule
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#action Wafv2RuleGroup#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleAction\"}")]
        aws.Wafv2.IWafv2RuleGroupRuleAction Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#name Wafv2RuleGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#priority Wafv2RuleGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#statement Wafv2RuleGroup#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatement\"}")]
        aws.Wafv2.IWafv2RuleGroupRuleStatement Statement
        {
            get;
        }

        /// <summary>visibility_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#visibility_config Wafv2RuleGroup#visibility_config}
        /// </remarks>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleVisibilityConfig\"}")]
        aws.Wafv2.IWafv2RuleGroupRuleVisibilityConfig VisibilityConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRule), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRule")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#action Wafv2RuleGroup#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleAction\"}")]
            public aws.Wafv2.IWafv2RuleGroupRuleAction Action
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleAction>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#name Wafv2RuleGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#priority Wafv2RuleGroup#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#statement Wafv2RuleGroup#statement}
            /// </remarks>
            [JsiiProperty(name: "statement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatement\"}")]
            public aws.Wafv2.IWafv2RuleGroupRuleStatement Statement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatement>()!;
            }

            /// <summary>visibility_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#visibility_config Wafv2RuleGroup#visibility_config}
            /// </remarks>
            [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleVisibilityConfig\"}")]
            public aws.Wafv2.IWafv2RuleGroupRuleVisibilityConfig VisibilityConfig
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleVisibilityConfig>()!;
            }
        }
    }
}
