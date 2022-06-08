using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatement")]
    public interface IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatement
    {
        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#byte_match_statement Wafv2WebAcl#byte_match_statement}
        /// </remarks>
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement? ByteMatchStatement
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
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement? GeoMatchStatement
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
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
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
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
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
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement? SizeConstraintStatement
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
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement? SqliMatchStatement
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
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement? XssMatchStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>byte_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#byte_match_statement Wafv2WebAcl#byte_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement? ByteMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement?>();
            }

            /// <summary>geo_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#geo_match_statement Wafv2WebAcl#geo_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement? GeoMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement?>();
            }

            /// <summary>ip_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#ip_set_reference_statement Wafv2WebAcl#ip_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement? IpSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement?>();
            }

            /// <summary>regex_pattern_set_reference_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#regex_pattern_set_reference_statement Wafv2WebAcl#regex_pattern_set_reference_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement?>();
            }

            /// <summary>size_constraint_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#size_constraint_statement Wafv2WebAcl#size_constraint_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement? SizeConstraintStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement?>();
            }

            /// <summary>sqli_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#sqli_match_statement Wafv2WebAcl#sqli_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement? SqliMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement?>();
            }

            /// <summary>xss_match_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#xss_match_statement Wafv2WebAcl#xss_match_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement? XssMatchStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement?>();
            }
        }
    }
}
