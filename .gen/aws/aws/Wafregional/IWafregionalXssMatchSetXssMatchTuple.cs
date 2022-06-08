using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalXssMatchSetXssMatchTuple), fullyQualifiedName: "aws.wafregional.WafregionalXssMatchSetXssMatchTuple")]
    public interface IWafregionalXssMatchSetXssMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_xss_match_set#field_to_match WafregionalXssMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalXssMatchSetXssMatchTupleFieldToMatch\"}")]
        aws.Wafregional.IWafregionalXssMatchSetXssMatchTupleFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_xss_match_set#text_transformation WafregionalXssMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalXssMatchSetXssMatchTuple), fullyQualifiedName: "aws.wafregional.WafregionalXssMatchSetXssMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalXssMatchSetXssMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_xss_match_set#field_to_match WafregionalXssMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalXssMatchSetXssMatchTupleFieldToMatch\"}")]
            public aws.Wafregional.IWafregionalXssMatchSetXssMatchTupleFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafregional.IWafregionalXssMatchSetXssMatchTupleFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_xss_match_set#text_transformation WafregionalXssMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
