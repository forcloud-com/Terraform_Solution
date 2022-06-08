using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatement")]
    public class Wafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatement : aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#positional_constraint Wafv2RuleGroup#positional_constraint}.</summary>
        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public string PositionalConstraint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#search_string Wafv2RuleGroup#search_string}.</summary>
        [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}")]
        public string SearchString
        {
            get;
            set;
        }

        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatementTextTransformation\"},\"kind\":\"array\"}}]}}")]
        public object TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatementFieldToMatch\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatementFieldToMatch? FieldToMatch
        {
            get;
            set;
        }
    }
}
