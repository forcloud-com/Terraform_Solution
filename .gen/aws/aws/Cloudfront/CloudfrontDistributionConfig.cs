using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    /// <summary>AWS CloudFront.</summary>
    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionConfig")]
    public class CloudfrontDistributionConfig : aws.Cloudfront.ICloudfrontDistributionConfig
    {
        /// <summary>default_cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_cache_behavior CloudfrontDistribution#default_cache_behavior}
        /// </remarks>
        [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehavior\"}")]
        public aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior DefaultCacheBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#enabled CloudfrontDistribution#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }

        /// <summary>origin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin CloudfrontDistribution#origin}
        /// </remarks>
        [JsiiProperty(name: "origin", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}]}}")]
        public object Origin
        {
            get;
            set;
        }

        /// <summary>restrictions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#restrictions CloudfrontDistribution#restrictions}
        /// </remarks>
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictions\"}")]
        public aws.Cloudfront.ICloudfrontDistributionRestrictions Restrictions
        {
            get;
            set;
        }

        /// <summary>viewer_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#viewer_certificate CloudfrontDistribution#viewer_certificate}
        /// </remarks>
        [JsiiProperty(name: "viewerCertificate", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionViewerCertificate\"}")]
        public aws.Cloudfront.ICloudfrontDistributionViewerCertificate ViewerCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#aliases CloudfrontDistribution#aliases}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Aliases
        {
            get;
            set;
        }

        /// <summary>cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cache_behavior CloudfrontDistribution#cache_behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CacheBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#comment CloudfrontDistribution#comment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Comment
        {
            get;
            set;
        }

        /// <summary>custom_error_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_error_response CloudfrontDistribution#custom_error_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customErrorResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomErrorResponse
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_root_object CloudfrontDistribution#default_root_object}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultRootObject
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#http_version CloudfrontDistribution#http_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#is_ipv6_enabled CloudfrontDistribution#is_ipv6_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isIpv6Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IsIpv6Enabled
        {
            get;
            set;
        }

        /// <summary>logging_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#logging_config CloudfrontDistribution#logging_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loggingConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionLoggingConfig\"}", isOptional: true)]
        public aws.Cloudfront.ICloudfrontDistributionLoggingConfig? LoggingConfig
        {
            get;
            set;
        }

        /// <summary>ordered_cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#ordered_cache_behavior CloudfrontDistribution#ordered_cache_behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orderedCacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OrderedCacheBehavior
        {
            get;
            set;
        }

        /// <summary>origin_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_group CloudfrontDistribution#origin_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OriginGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#price_class CloudfrontDistribution#price_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priceClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PriceClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#retain_on_delete CloudfrontDistribution#retain_on_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retainOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RetainOnDelete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#tags CloudfrontDistribution#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#wait_for_deployment CloudfrontDistribution#wait_for_deployment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitForDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? WaitForDeployment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#web_acl_id CloudfrontDistribution#web_acl_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebAclId
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
