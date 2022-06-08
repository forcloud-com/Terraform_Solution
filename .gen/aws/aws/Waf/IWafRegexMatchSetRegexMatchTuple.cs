using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.waf.WafRegexMatchSetRegexMatchTuple")]
    public interface IWafRegexMatchSetRegexMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#field_to_match WafRegexMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafRegexMatchSetRegexMatchTupleFieldToMatch\"}")]
        aws.Waf.IWafRegexMatchSetRegexMatchTupleFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#regex_pattern_set_id WafRegexMatchSet#regex_pattern_set_id}.</summary>
        [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
        string RegexPatternSetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#text_transformation WafRegexMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.waf.WafRegexMatchSetRegexMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafRegexMatchSetRegexMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#field_to_match WafRegexMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafRegexMatchSetRegexMatchTupleFieldToMatch\"}")]
            public aws.Waf.IWafRegexMatchSetRegexMatchTupleFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.Waf.IWafRegexMatchSetRegexMatchTupleFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#regex_pattern_set_id WafRegexMatchSet#regex_pattern_set_id}.</summary>
            [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
            public string RegexPatternSetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_regex_match_set#text_transformation WafRegexMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
