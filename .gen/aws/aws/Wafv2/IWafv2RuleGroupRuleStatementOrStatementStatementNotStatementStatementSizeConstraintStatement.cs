using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement")]
    public interface IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#comparison_operator Wafv2RuleGroup#comparison_operator}.</summary>
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ComparisonOperator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#size Wafv2RuleGroup#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation\"},\"kind\":\"array\"}}]}}")]
        object TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#comparison_operator Wafv2RuleGroup#comparison_operator}.</summary>
            [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ComparisonOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#size Wafv2RuleGroup#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>text_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
            /// </remarks>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation\"},\"kind\":\"array\"}}]}}")]
            public object TextTransformation
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch? FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch?>();
            }
        }
    }
}
