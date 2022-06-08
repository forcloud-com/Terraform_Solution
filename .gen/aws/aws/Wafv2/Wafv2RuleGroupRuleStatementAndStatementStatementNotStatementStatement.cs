using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatement")]
    public class Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatement : aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatement
    {
        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#byte_match_statement Wafv2RuleGroup#byte_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementByteMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementByteMatchStatement? ByteMatchStatement
        {
            get;
            set;
        }

        /// <summary>geo_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#geo_match_statement Wafv2RuleGroup#geo_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementGeoMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementGeoMatchStatement? GeoMatchStatement
        {
            get;
            set;
        }

        /// <summary>ip_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#ip_set_reference_statement Wafv2RuleGroup#ip_set_reference_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#regex_pattern_set_reference_statement Wafv2RuleGroup#regex_pattern_set_reference_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>size_constraint_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#size_constraint_statement Wafv2RuleGroup#size_constraint_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSizeConstraintStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSizeConstraintStatement? SizeConstraintStatement
        {
            get;
            set;
        }

        /// <summary>sqli_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#sqli_match_statement Wafv2RuleGroup#sqli_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementSqliMatchStatement? SqliMatchStatement
        {
            get;
            set;
        }

        /// <summary>xss_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#xss_match_statement Wafv2RuleGroup#xss_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementXssMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementXssMatchStatement? XssMatchStatement
        {
            get;
            set;
        }
    }
}
