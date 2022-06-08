using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatement")]
    public interface IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatementTextTransformation\"},\"kind\":\"array\"}}]}}")]
        object TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>text_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
            /// </remarks>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatementTextTransformation\"},\"kind\":\"array\"}}]}}")]
            public object TextTransformation
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch? FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch?>();
            }
        }
    }
}
