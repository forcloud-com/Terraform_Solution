using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader")]
    public interface IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
