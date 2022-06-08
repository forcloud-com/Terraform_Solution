using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementGeoMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementGeoMatchStatement")]
    public interface IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementGeoMatchStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#country_codes Wafv2RuleGroup#country_codes}.</summary>
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CountryCodes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementGeoMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementGeoMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementNotStatementStatementGeoMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#country_codes Wafv2RuleGroup#country_codes}.</summary>
            [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CountryCodes
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
