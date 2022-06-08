using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafSqlInjectionMatchSetSqlInjectionMatchTuples), fullyQualifiedName: "aws.waf.WafSqlInjectionMatchSetSqlInjectionMatchTuples")]
    public interface IWafSqlInjectionMatchSetSqlInjectionMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#field_to_match WafSqlInjectionMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch\"}")]
        aws.Waf.IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#text_transformation WafSqlInjectionMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafSqlInjectionMatchSetSqlInjectionMatchTuples), fullyQualifiedName: "aws.waf.WafSqlInjectionMatchSetSqlInjectionMatchTuples")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafSqlInjectionMatchSetSqlInjectionMatchTuples
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#field_to_match WafSqlInjectionMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch\"}")]
            public aws.Waf.IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.Waf.IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#text_transformation WafSqlInjectionMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
