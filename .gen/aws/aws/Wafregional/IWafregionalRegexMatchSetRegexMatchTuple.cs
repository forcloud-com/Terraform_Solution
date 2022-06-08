using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.wafregional.WafregionalRegexMatchSetRegexMatchTuple")]
    public interface IWafregionalRegexMatchSetRegexMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_regex_match_set#field_to_match WafregionalRegexMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalRegexMatchSetRegexMatchTupleFieldToMatch\"}")]
        aws.Wafregional.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_regex_match_set#regex_pattern_set_id WafregionalRegexMatchSet#regex_pattern_set_id}.</summary>
        [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
        string RegexPatternSetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_regex_match_set#text_transformation WafregionalRegexMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.wafregional.WafregionalRegexMatchSetRegexMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalRegexMatchSetRegexMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_regex_match_set#field_to_match WafregionalRegexMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalRegexMatchSetRegexMatchTupleFieldToMatch\"}")]
            public aws.Wafregional.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafregional.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_regex_match_set#regex_pattern_set_id WafregionalRegexMatchSet#regex_pattern_set_id}.</summary>
            [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
            public string RegexPatternSetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_regex_match_set#text_transformation WafregionalRegexMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
