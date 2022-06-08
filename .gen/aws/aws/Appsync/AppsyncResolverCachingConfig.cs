using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiByValue(fqn: "aws.appsync.AppsyncResolverCachingConfig")]
    public class AppsyncResolverCachingConfig : aws.Appsync.IAppsyncResolverCachingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#caching_keys AppsyncResolver#caching_keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cachingKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CachingKeys
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#ttl AppsyncResolver#ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ttl
        {
            get;
            set;
        }
    }
}
