using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatement")]
    public class Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatement : aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatement
    {
        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#byte_match_statement Wafv2WebAcl#byte_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementByteMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementByteMatchStatement? ByteMatchStatement
        {
            get;
            set;
        }

        /// <summary>geo_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#geo_match_statement Wafv2WebAcl#geo_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementGeoMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementGeoMatchStatement? GeoMatchStatement
        {
            get;
            set;
        }

        /// <summary>ip_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#ip_set_reference_statement Wafv2WebAcl#ip_set_reference_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#regex_pattern_set_reference_statement Wafv2WebAcl#regex_pattern_set_reference_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>size_constraint_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#size_constraint_statement Wafv2WebAcl#size_constraint_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementSizeConstraintStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementSizeConstraintStatement? SizeConstraintStatement
        {
            get;
            set;
        }

        /// <summary>sqli_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#sqli_match_statement Wafv2WebAcl#sqli_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementSqliMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementSqliMatchStatement? SqliMatchStatement
        {
            get;
            set;
        }

        /// <summary>xss_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#xss_match_statement Wafv2WebAcl#xss_match_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementXssMatchStatement\"}", isOptional: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementXssMatchStatement? XssMatchStatement
        {
            get;
            set;
        }
    }
}
