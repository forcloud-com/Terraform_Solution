using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatement")]
    public interface IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}]}}")]
        object Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
            /// </remarks>
            [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}]}}")]
            public object Statement
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
