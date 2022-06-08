using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionCacheBehaviorForwardedValues")]
    public class CloudfrontDistributionCacheBehaviorForwardedValues : aws.Cloudfront.ICloudfrontDistributionCacheBehaviorForwardedValues
    {
        /// <summary>cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cookies CloudfrontDistribution#cookies}
        /// </remarks>
        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCacheBehaviorForwardedValuesCookies\"}")]
        public aws.Cloudfront.ICloudfrontDistributionCacheBehaviorForwardedValuesCookies Cookies
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#query_string CloudfrontDistribution#query_string}.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object QueryString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#headers CloudfrontDistribution#headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Headers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#query_string_cache_keys CloudfrontDistribution#query_string_cache_keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryStringCacheKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? QueryStringCacheKeys
        {
            get;
            set;
        }
    }
}
