using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple), fullyQualifiedName: "aws.wafregional.WafregionalSqlInjectionMatchSetSqlInjectionMatchTuple")]
    public interface IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_sql_injection_match_set#field_to_match WafregionalSqlInjectionMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch\"}")]
        aws.Wafregional.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_sql_injection_match_set#text_transformation WafregionalSqlInjectionMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple), fullyQualifiedName: "aws.wafregional.WafregionalSqlInjectionMatchSetSqlInjectionMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_sql_injection_match_set#field_to_match WafregionalSqlInjectionMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch\"}")]
            public aws.Wafregional.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafregional.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_sql_injection_match_set#text_transformation WafregionalSqlInjectionMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
