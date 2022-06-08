using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatement")]
    public interface IWafv2RuleGroupRuleStatementAndStatementStatement
    {
        /// <summary>and_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#and_statement Wafv2RuleGroup#and_statement}
        /// </remarks>
        [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatement? AndStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#byte_match_statement Wafv2RuleGroup#byte_match_statement}
        /// </remarks>
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatement? ByteMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>geo_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#geo_match_statement Wafv2RuleGroup#geo_match_statement}
        /// </remarks>
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementGeoMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementGeoMatchStatement? GeoMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#ip_set_reference_statement Wafv2RuleGroup#ip_set_reference_statement}
        /// </remarks>
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>not_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#not_statement Wafv2RuleGroup#not_statement}
        /// </remarks>
        [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatement? NotStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>or_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#or_statement Wafv2RuleGroup#or_statement}
        /// </remarks>
        [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementOrStatement? OrStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#regex_pattern_set_reference_statement Wafv2RuleGroup#regex_pattern_set_reference_statement}
        /// </remarks>
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>size_constraint_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#size_constraint_statement Wafv2RuleGroup#size_constraint_statement}
        /// </remarks>
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementSizeConstraintStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementSizeConstraintStatement? SizeConstraintStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqli_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#sqli_match_statement Wafv2RuleGroup#sqli_match_statement}
        /// </remarks>
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementSqliMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementSqliMatchStatement? SqliMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>xss_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#xss_match_statement Wafv2RuleGroup#xss_match_statement}
        /// </remarks>
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementXssMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementXssMatchStatement? XssMatchStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#and_statement Wafv2RuleGroup#and_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatement? AndStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatement?>();
            }

            /// <summary>byte_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#byte_match_statement Wafv2RuleGroup#byte_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatement? ByteMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementByteMatchStatement?>();
            }

            /// <summary>geo_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#geo_match_statement Wafv2RuleGroup#geo_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementGeoMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementGeoMatchStatement? GeoMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementGeoMatchStatement?>();
            }

            /// <summary>ip_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#ip_set_reference_statement Wafv2RuleGroup#ip_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementIpSetReferenceStatement?>();
            }

            /// <summary>not_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#not_statement Wafv2RuleGroup#not_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatement? NotStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatement?>();
            }

            /// <summary>or_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#or_statement Wafv2RuleGroup#or_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementOrStatement? OrStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementOrStatement?>();
            }

            /// <summary>regex_pattern_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#regex_pattern_set_reference_statement Wafv2RuleGroup#regex_pattern_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementRegexPatternSetReferenceStatement?>();
            }

            /// <summary>size_constraint_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#size_constraint_statement Wafv2RuleGroup#size_constraint_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementSizeConstraintStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementSizeConstraintStatement? SizeConstraintStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementSizeConstraintStatement?>();
            }

            /// <summary>sqli_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#sqli_match_statement Wafv2RuleGroup#sqli_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementSqliMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementSqliMatchStatement? SqliMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementSqliMatchStatement?>();
            }

            /// <summary>xss_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#xss_match_statement Wafv2RuleGroup#xss_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementXssMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementXssMatchStatement? XssMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementXssMatchStatement?>();
            }
        }
    }
}
