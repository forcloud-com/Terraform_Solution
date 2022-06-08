using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementOrStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatement")]
    public interface IWafv2RuleGroupRuleStatementNotStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#statement Wafv2RuleGroup#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}]}}")]
        object Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementOrStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#statement Wafv2RuleGroup#statement}
            /// </remarks>
            [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}]}}")]
            public object Statement
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
