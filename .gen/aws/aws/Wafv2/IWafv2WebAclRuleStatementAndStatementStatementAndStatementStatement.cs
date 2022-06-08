using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatement
    {
        /// <summary>and_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#and_statement Wafv2WebAcl#and_statement}
        /// </remarks>
        [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatement? AndStatement
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
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement? ByteMatchStatement
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
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementGeoMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementGeoMatchStatement? GeoMatchStatement
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
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
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
        [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatement? NotStatement
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
        [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatement? OrStatement
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
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
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
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSizeConstraintStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSizeConstraintStatement? SizeConstraintStatement
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
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSqliMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSqliMatchStatement? SqliMatchStatement
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
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement? XssMatchStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#and_statement Wafv2WebAcl#and_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatement? AndStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatement?>();
            }

            /// <summary>byte_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#byte_match_statement Wafv2WebAcl#byte_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement? ByteMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement?>();
            }

            /// <summary>geo_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#geo_match_statement Wafv2WebAcl#geo_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementGeoMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementGeoMatchStatement? GeoMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementGeoMatchStatement?>();
            }

            /// <summary>ip_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#ip_set_reference_statement Wafv2WebAcl#ip_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementIpSetReferenceStatement?>();
            }

            /// <summary>not_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#not_statement Wafv2WebAcl#not_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatement? NotStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatement?>();
            }

            /// <summary>or_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#or_statement Wafv2WebAcl#or_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatement? OrStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatement?>();
            }

            /// <summary>regex_pattern_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#regex_pattern_set_reference_statement Wafv2WebAcl#regex_pattern_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement?>();
            }

            /// <summary>size_constraint_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#size_constraint_statement Wafv2WebAcl#size_constraint_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSizeConstraintStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSizeConstraintStatement? SizeConstraintStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSizeConstraintStatement?>();
            }

            /// <summary>sqli_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#sqli_match_statement Wafv2WebAcl#sqli_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSqliMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSqliMatchStatement? SqliMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementSqliMatchStatement?>();
            }

            /// <summary>xss_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#xss_match_statement Wafv2WebAcl#xss_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement? XssMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement?>();
            }
        }
    }
}
