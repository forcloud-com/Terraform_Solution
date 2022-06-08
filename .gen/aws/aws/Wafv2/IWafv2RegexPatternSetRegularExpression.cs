using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RegexPatternSetRegularExpression), fullyQualifiedName: "aws.wafv2.Wafv2RegexPatternSetRegularExpression")]
    public interface IWafv2RegexPatternSetRegularExpression
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_regex_pattern_set#regex_string Wafv2RegexPatternSet#regex_string}.</summary>
        [JsiiProperty(name: "regexString", typeJson: "{\"primitive\":\"string\"}")]
        string RegexString
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RegexPatternSetRegularExpression), fullyQualifiedName: "aws.wafv2.Wafv2RegexPatternSetRegularExpression")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RegexPatternSetRegularExpression
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_regex_pattern_set#regex_string Wafv2RegexPatternSet#regex_string}.</summary>
            [JsiiProperty(name: "regexString", typeJson: "{\"primitive\":\"string\"}")]
            public string RegexString
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
