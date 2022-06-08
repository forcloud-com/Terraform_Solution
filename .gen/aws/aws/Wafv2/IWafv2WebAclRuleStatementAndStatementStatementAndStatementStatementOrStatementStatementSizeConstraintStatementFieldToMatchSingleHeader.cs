using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader
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
