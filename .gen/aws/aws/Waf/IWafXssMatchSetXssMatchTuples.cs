using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafXssMatchSetXssMatchTuples), fullyQualifiedName: "aws.waf.WafXssMatchSetXssMatchTuples")]
    public interface IWafXssMatchSetXssMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_xss_match_set#field_to_match WafXssMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafXssMatchSetXssMatchTuplesFieldToMatch\"}")]
        aws.Waf.IWafXssMatchSetXssMatchTuplesFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_xss_match_set#text_transformation WafXssMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafXssMatchSetXssMatchTuples), fullyQualifiedName: "aws.waf.WafXssMatchSetXssMatchTuples")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafXssMatchSetXssMatchTuples
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_xss_match_set#field_to_match WafXssMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafXssMatchSetXssMatchTuplesFieldToMatch\"}")]
            public aws.Waf.IWafXssMatchSetXssMatchTuplesFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.Waf.IWafXssMatchSetXssMatchTuplesFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_xss_match_set#text_transformation WafXssMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
