using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOrderedCacheBehavior), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrderedCacheBehavior")]
    public interface ICloudfrontDistributionOrderedCacheBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#allowed_methods CloudfrontDistribution#allowed_methods}.</summary>
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedMethods
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cached_methods CloudfrontDistribution#cached_methods}.</summary>
        [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CachedMethods
        {
            get;
        }

        /// <summary>forwarded_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#forwarded_values CloudfrontDistribution#forwarded_values}
        /// </remarks>
        [JsiiProperty(name: "forwardedValues", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValues\"}")]
        aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues ForwardedValues
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#path_pattern CloudfrontDistribution#path_pattern}.</summary>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
        string PathPattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#target_origin_id CloudfrontDistribution#target_origin_id}.</summary>
        [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetOriginId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#viewer_protocol_policy CloudfrontDistribution#viewer_protocol_policy}.</summary>
        [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string ViewerProtocolPolicy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#compress CloudfrontDistribution#compress}.</summary>
        [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Compress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_ttl CloudfrontDistribution#default_ttl}.</summary>
        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#field_level_encryption_id CloudfrontDistribution#field_level_encryption_id}.</summary>
        [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FieldLevelEncryptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#lambda_function_association CloudfrontDistribution#lambda_function_association}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaFunctionAssociation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#max_ttl CloudfrontDistribution#max_ttl}.</summary>
        [JsiiProperty(name: "maxTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#min_ttl CloudfrontDistribution#min_ttl}.</summary>
        [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#smooth_streaming CloudfrontDistribution#smooth_streaming}.</summary>
        [JsiiProperty(name: "smoothStreaming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SmoothStreaming
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#trusted_signers CloudfrontDistribution#trusted_signers}.</summary>
        [JsiiProperty(name: "trustedSigners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustedSigners
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOrderedCacheBehavior), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrderedCacheBehavior")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#allowed_methods CloudfrontDistribution#allowed_methods}.</summary>
            [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedMethods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cached_methods CloudfrontDistribution#cached_methods}.</summary>
            [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CachedMethods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>forwarded_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#forwarded_values CloudfrontDistribution#forwarded_values}
            /// </remarks>
            [JsiiProperty(name: "forwardedValues", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValues\"}")]
            public aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues ForwardedValues
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#path_pattern CloudfrontDistribution#path_pattern}.</summary>
            [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
            public string PathPattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#target_origin_id CloudfrontDistribution#target_origin_id}.</summary>
            [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetOriginId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#viewer_protocol_policy CloudfrontDistribution#viewer_protocol_policy}.</summary>
            [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string ViewerProtocolPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#compress CloudfrontDistribution#compress}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Compress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_ttl CloudfrontDistribution#default_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#field_level_encryption_id CloudfrontDistribution#field_level_encryption_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FieldLevelEncryptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lambda_function_association block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#lambda_function_association CloudfrontDistribution#lambda_function_association}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaFunctionAssociation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#max_ttl CloudfrontDistribution#max_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#min_ttl CloudfrontDistribution#min_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#smooth_streaming CloudfrontDistribution#smooth_streaming}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smoothStreaming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SmoothStreaming
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#trusted_signers CloudfrontDistribution#trusted_signers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedSigners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustedSigners
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
