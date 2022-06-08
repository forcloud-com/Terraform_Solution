using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatement")]
    public interface IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatement
    {
        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#byte_match_statement Wafv2RuleGroup#byte_match_statement}
        /// </remarks>
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementByteMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementByteMatchStatement? ByteMatchStatement
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
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementGeoMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementGeoMatchStatement? GeoMatchStatement
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
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
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
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
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
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement? SizeConstraintStatement
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
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatement? SqliMatchStatement
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
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementXssMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementXssMatchStatement? XssMatchStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>byte_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#byte_match_statement Wafv2RuleGroup#byte_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementByteMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementByteMatchStatement? ByteMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementByteMatchStatement?>();
            }

            /// <summary>geo_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#geo_match_statement Wafv2RuleGroup#geo_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementGeoMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementGeoMatchStatement? GeoMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementGeoMatchStatement?>();
            }

            /// <summary>ip_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#ip_set_reference_statement Wafv2RuleGroup#ip_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementIpSetReferenceStatement?>();
            }

            /// <summary>regex_pattern_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#regex_pattern_set_reference_statement Wafv2RuleGroup#regex_pattern_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementRegexPatternSetReferenceStatement?>();
            }

            /// <summary>size_constraint_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#size_constraint_statement Wafv2RuleGroup#size_constraint_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement? SizeConstraintStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement?>();
            }

            /// <summary>sqli_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#sqli_match_statement Wafv2RuleGroup#sqli_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatement? SqliMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatement?>();
            }

            /// <summary>xss_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#xss_match_statement Wafv2RuleGroup#xss_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementXssMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementXssMatchStatement? XssMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementXssMatchStatement?>();
            }
        }
    }
}
