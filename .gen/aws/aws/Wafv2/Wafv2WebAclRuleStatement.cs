using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatement")]
    public class Wafv2WebAclRuleStatement : aws.Wafv2.IWafv2WebAclRuleStatement
    {
        /// <summary>and_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#and_statement Wafv2WebAcl#and_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementAndStatement? AndStatement
        {
            get;
            set;
        }

        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#byte_match_statement Wafv2WebAcl#byte_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementByteMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementByteMatchStatement? ByteMatchStatement
        {
            get;
            set;
        }

        /// <summary>geo_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#geo_match_statement Wafv2WebAcl#geo_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementGeoMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementGeoMatchStatement? GeoMatchStatement
        {
            get;
            set;
        }

        /// <summary>ip_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#ip_set_reference_statement Wafv2WebAcl#ip_set_reference_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementIpSetReferenceStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementIpSetReferenceStatement? IpSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>managed_rule_group_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#managed_rule_group_statement Wafv2WebAcl#managed_rule_group_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedRuleGroupStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatement? ManagedRuleGroupStatement
        {
            get;
            set;
        }

        /// <summary>not_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#not_statement Wafv2WebAcl#not_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatement? NotStatement
        {
            get;
            set;
        }

        /// <summary>or_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#or_statement Wafv2WebAcl#or_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatement? OrStatement
        {
            get;
            set;
        }

        /// <summary>rate_based_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#rate_based_statement Wafv2WebAcl#rate_based_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rateBasedStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatement? RateBasedStatement
        {
            get;
            set;
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#regex_pattern_set_reference_statement Wafv2WebAcl#regex_pattern_set_reference_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>rule_group_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#rule_group_reference_statement Wafv2WebAcl#rule_group_reference_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleGroupReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRuleGroupReferenceStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementRuleGroupReferenceStatement? RuleGroupReferenceStatement
        {
            get;
            set;
        }

        /// <summary>size_constraint_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#size_constraint_statement Wafv2WebAcl#size_constraint_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementSizeConstraintStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementSizeConstraintStatement? SizeConstraintStatement
        {
            get;
            set;
        }

        /// <summary>sqli_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#sqli_match_statement Wafv2WebAcl#sqli_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementSqliMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementSqliMatchStatement? SqliMatchStatement
        {
            get;
            set;
        }

        /// <summary>xss_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#xss_match_statement Wafv2WebAcl#xss_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementXssMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementXssMatchStatement? XssMatchStatement
        {
            get;
            set;
        }
    }
}
