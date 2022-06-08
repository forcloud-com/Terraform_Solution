using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatement")]
    public interface IWafv2WebAclRuleStatementRateBasedStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#limit Wafv2WebAcl#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        double Limit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#aggregate_key_type Wafv2WebAcl#aggregate_key_type}.</summary>
        [JsiiProperty(name: "aggregateKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AggregateKeyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>scope_down_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#scope_down_statement Wafv2WebAcl#scope_down_statement}
        /// </remarks>
        [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement? ScopeDownStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#limit Wafv2WebAcl#limit}.</summary>
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
            public double Limit
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#aggregate_key_type Wafv2WebAcl#aggregate_key_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aggregateKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AggregateKeyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scope_down_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#scope_down_statement Wafv2WebAcl#scope_down_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement? ScopeDownStatement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement?>();
            }
        }
    }
}
