using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSqliMatchStatementTextTransformation), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSqliMatchStatementTextTransformation")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSqliMatchStatementTextTransformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#priority Wafv2WebAcl#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#type Wafv2WebAcl#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSqliMatchStatementTextTransformation), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSqliMatchStatementTextTransformation")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSqliMatchStatementTextTransformation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#priority Wafv2WebAcl#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#type Wafv2WebAcl#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
