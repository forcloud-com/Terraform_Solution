using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AwsProviderIgnoreTags")]
    public class AwsProviderIgnoreTags : aws.IAwsProviderIgnoreTags
    {
        /// <summary>Resource tag key prefixes to ignore across all resources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#key_prefixes AwsProvider#key_prefixes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? KeyPrefixes
        {
            get;
            set;
        }

        /// <summary>Resource tag keys to ignore across all resources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#keys AwsProvider#keys}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Keys
        {
            get;
            set;
        }
    }
}
