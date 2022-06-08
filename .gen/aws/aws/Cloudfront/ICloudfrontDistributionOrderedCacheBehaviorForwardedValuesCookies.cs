using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies")]
    public interface ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#forward CloudfrontDistribution#forward}.</summary>
        [JsiiProperty(name: "forward", typeJson: "{\"primitive\":\"string\"}")]
        string Forward
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#whitelisted_names CloudfrontDistribution#whitelisted_names}.</summary>
        [JsiiProperty(name: "whitelistedNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WhitelistedNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#forward CloudfrontDistribution#forward}.</summary>
            [JsiiProperty(name: "forward", typeJson: "{\"primitive\":\"string\"}")]
            public string Forward
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#whitelisted_names CloudfrontDistribution#whitelisted_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "whitelistedNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WhitelistedNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
