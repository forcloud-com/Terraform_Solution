using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    /// <summary>AWS WAF Regional.</summary>
    [JsiiInterface(nativeType: typeof(IWafregionalByteMatchSetConfig), fullyQualifiedName: "aws.wafregional.WafregionalByteMatchSetConfig")]
    public interface IWafregionalByteMatchSetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_byte_match_set#name WafregionalByteMatchSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>byte_match_tuple block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_byte_match_set#byte_match_tuple WafregionalByteMatchSet#byte_match_tuple}
        /// </remarks>
        [JsiiProperty(name: "byteMatchTuple", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalByteMatchSetByteMatchTuple\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ByteMatchTuple
        {
            get
            {
                return null;
            }
        }

        /// <summary>byte_match_tuples block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_byte_match_set#byte_match_tuples WafregionalByteMatchSet#byte_match_tuples}
        /// </remarks>
        [JsiiProperty(name: "byteMatchTuples", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalByteMatchSetByteMatchTuples\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ByteMatchTuples
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS WAF Regional.</summary>
        [JsiiTypeProxy(nativeType: typeof(IWafregionalByteMatchSetConfig), fullyQualifiedName: "aws.wafregional.WafregionalByteMatchSetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalByteMatchSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_byte_match_set#name WafregionalByteMatchSet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>byte_match_tuple block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_byte_match_set#byte_match_tuple WafregionalByteMatchSet#byte_match_tuple}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchTuple", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalByteMatchSetByteMatchTuple\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ByteMatchTuple
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>byte_match_tuples block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_byte_match_set#byte_match_tuples WafregionalByteMatchSet#byte_match_tuples}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchTuples", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalByteMatchSetByteMatchTuples\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ByteMatchTuples
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
