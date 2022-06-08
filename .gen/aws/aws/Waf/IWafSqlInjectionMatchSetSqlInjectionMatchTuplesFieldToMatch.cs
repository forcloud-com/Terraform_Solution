using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch), fullyQualifiedName: "aws.waf.WafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch")]
    public interface IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#type WafSqlInjectionMatchSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#data WafSqlInjectionMatchSet#data}.</summary>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Data
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch), fullyQualifiedName: "aws.waf.WafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#type WafSqlInjectionMatchSet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#data WafSqlInjectionMatchSet#data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Data
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
