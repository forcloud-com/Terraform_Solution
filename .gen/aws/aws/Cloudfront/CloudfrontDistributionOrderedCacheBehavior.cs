using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionOrderedCacheBehavior")]
    public class CloudfrontDistributionOrderedCacheBehavior : aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#allowed_methods CloudfrontDistribution#allowed_methods}.</summary>
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AllowedMethods
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cached_methods CloudfrontDistribution#cached_methods}.</summary>
        [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CachedMethods
        {
            get;
            set;
        }

        /// <summary>forwarded_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#forwarded_values CloudfrontDistribution#forwarded_values}
        /// </remarks>
        [JsiiProperty(name: "forwardedValues", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValues\"}")]
        public aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues ForwardedValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#path_pattern CloudfrontDistribution#path_pattern}.</summary>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
        public string PathPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#target_origin_id CloudfrontDistribution#target_origin_id}.</summary>
        [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetOriginId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#viewer_protocol_policy CloudfrontDistribution#viewer_protocol_policy}.</summary>
        [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public string ViewerProtocolPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#compress CloudfrontDistribution#compress}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Compress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_ttl CloudfrontDistribution#default_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DefaultTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#field_level_encryption_id CloudfrontDistribution#field_level_encryption_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FieldLevelEncryptionId
        {
            get;
            set;
        }

        /// <summary>lambda_function_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#lambda_function_association CloudfrontDistribution#lambda_function_association}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaFunctionAssociation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#max_ttl CloudfrontDistribution#max_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#min_ttl CloudfrontDistribution#min_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#smooth_streaming CloudfrontDistribution#smooth_streaming}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smoothStreaming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SmoothStreaming
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#trusted_signers CloudfrontDistribution#trusted_signers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedSigners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustedSigners
        {
            get;
            set;
        }
    }
}
