using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement")]
    public interface IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#arn Wafv2WebAcl#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#arn Wafv2WebAcl#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
