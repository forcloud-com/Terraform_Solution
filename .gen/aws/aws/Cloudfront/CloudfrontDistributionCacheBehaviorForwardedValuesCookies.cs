using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionCacheBehaviorForwardedValuesCookies")]
    public class CloudfrontDistributionCacheBehaviorForwardedValuesCookies : aws.Cloudfront.ICloudfrontDistributionCacheBehaviorForwardedValuesCookies
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#forward CloudfrontDistribution#forward}.</summary>
        [JsiiProperty(name: "forward", typeJson: "{\"primitive\":\"string\"}")]
        public string Forward
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#whitelisted_names CloudfrontDistribution#whitelisted_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "whitelistedNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? WhitelistedNames
        {
            get;
            set;
        }
    }
}
