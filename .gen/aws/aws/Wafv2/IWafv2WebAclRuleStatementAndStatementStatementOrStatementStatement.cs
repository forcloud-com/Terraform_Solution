using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatement
    {
        /// <summary>and_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#and_statement Wafv2WebAcl#and_statement}
        /// </remarks>
        [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementAndStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementAndStatement? AndStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#byte_match_statement Wafv2WebAcl#byte_match_statement}
        /// </remarks>
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementByteMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementByteMatchStatement? ByteMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>geo_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#geo_match_statement Wafv2WebAcl#geo_match_statement}
        /// </remarks>
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementGeoMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementGeoMatchStatement? GeoMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#ip_set_reference_statement Wafv2WebAcl#ip_set_reference_statement}
        /// </remarks>
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>not_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#not_statement Wafv2WebAcl#not_statement}
        /// </remarks>
        [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatement? NotStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>or_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#or_statement Wafv2WebAcl#or_statement}
        /// </remarks>
        [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatement? OrStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#regex_pattern_set_reference_statement Wafv2WebAcl#regex_pattern_set_reference_statement}
        /// </remarks>
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>size_constraint_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#size_constraint_statement Wafv2WebAcl#size_constraint_statement}
        /// </remarks>
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSizeConstraintStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSizeConstraintStatement? SizeConstraintStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqli_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#sqli_match_statement Wafv2WebAcl#sqli_match_statement}
        /// </remarks>
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSqliMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSqliMatchStatement? SqliMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>xss_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#xss_match_statement Wafv2WebAcl#xss_match_statement}
        /// </remarks>
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementXssMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementXssMatchStatement? XssMatchStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#and_statement Wafv2WebAcl#and_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementAndStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementAndStatement? AndStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementAndStatement?>();
            }

            /// <summary>byte_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#byte_match_statement Wafv2WebAcl#byte_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementByteMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementByteMatchStatement? ByteMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementByteMatchStatement?>();
            }

            /// <summary>geo_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#geo_match_statement Wafv2WebAcl#geo_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementGeoMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementGeoMatchStatement? GeoMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementGeoMatchStatement?>();
            }

            /// <summary>ip_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#ip_set_reference_statement Wafv2WebAcl#ip_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementIpSetReferenceStatement?>();
            }

            /// <summary>not_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#not_statement Wafv2WebAcl#not_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatement? NotStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatement?>();
            }

            /// <summary>or_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#or_statement Wafv2WebAcl#or_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatement? OrStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatement?>();
            }

            /// <summary>regex_pattern_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#regex_pattern_set_reference_statement Wafv2WebAcl#regex_pattern_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementRegexPatternSetReferenceStatement?>();
            }

            /// <summary>size_constraint_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#size_constraint_statement Wafv2WebAcl#size_constraint_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSizeConstraintStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSizeConstraintStatement? SizeConstraintStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSizeConstraintStatement?>();
            }

            /// <summary>sqli_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#sqli_match_statement Wafv2WebAcl#sqli_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSqliMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSqliMatchStatement? SqliMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementSqliMatchStatement?>();
            }

            /// <summary>xss_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#xss_match_statement Wafv2WebAcl#xss_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementXssMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementXssMatchStatement? XssMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementXssMatchStatement?>();
            }
        }
    }
}
