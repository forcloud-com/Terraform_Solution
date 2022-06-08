using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatementOrStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatement")]
    public interface IWafv2RuleGroupRuleStatementAndStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#statement Wafv2RuleGroup#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}]}}")]
        object Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatementOrStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementOrStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#statement Wafv2RuleGroup#statement}
            /// </remarks>
            [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}]}}")]
            public object Statement
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
