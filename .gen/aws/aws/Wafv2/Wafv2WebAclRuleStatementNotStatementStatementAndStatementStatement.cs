using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatement")]
    public class Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatement : aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatement
    {
        /// <summary>and_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#and_statement Wafv2WebAcl#and_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement? AndStatement
        {
            get;
            set;
        }

        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#byte_match_statement Wafv2WebAcl#byte_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatement? ByteMatchStatement
        {
            get;
            set;
        }

        /// <summary>geo_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#geo_match_statement Wafv2WebAcl#geo_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementGeoMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementGeoMatchStatement? GeoMatchStatement
        {
            get;
            set;
        }

        /// <summary>ip_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#ip_set_reference_statement Wafv2WebAcl#ip_set_reference_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>not_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#not_statement Wafv2WebAcl#not_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatement? NotStatement
        {
            get;
            set;
        }

        /// <summary>or_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#or_statement Wafv2WebAcl#or_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementOrStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementOrStatement? OrStatement
        {
            get;
            set;
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#regex_pattern_set_reference_statement Wafv2WebAcl#regex_pattern_set_reference_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>size_constraint_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#size_constraint_statement Wafv2WebAcl#size_constraint_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSizeConstraintStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSizeConstraintStatement? SizeConstraintStatement
        {
            get;
            set;
        }

        /// <summary>sqli_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#sqli_match_statement Wafv2WebAcl#sqli_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementSqliMatchStatement? SqliMatchStatement
        {
            get;
            set;
        }

        /// <summary>xss_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#xss_match_statement Wafv2WebAcl#xss_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementXssMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementXssMatchStatement? XssMatchStatement
        {
            get;
            set;
        }
    }
}
