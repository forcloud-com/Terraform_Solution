using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAwsProviderIgnoreTags), fullyQualifiedName: "aws.AwsProviderIgnoreTags")]
    public interface IAwsProviderIgnoreTags
    {
        /// <summary>Resource tag key prefixes to ignore across all resources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#key_prefixes AwsProvider#key_prefixes}
        /// </remarks>
        [JsiiProperty(name: "keyPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? KeyPrefixes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resource tag keys to ignore across all resources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#keys AwsProvider#keys}
        /// </remarks>
        [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Keys
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAwsProviderIgnoreTags), fullyQualifiedName: "aws.AwsProviderIgnoreTags")]
        internal sealed class _Proxy : DeputyBase, aws.IAwsProviderIgnoreTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Resource tag key prefixes to ignore across all resources.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#key_prefixes AwsProvider#key_prefixes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? KeyPrefixes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Resource tag keys to ignore across all resources.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#keys AwsProvider#keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Keys
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
