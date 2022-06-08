using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>AWS CloudFront.</summary>
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionConfig")]
    public interface ICloudfrontDistributionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>default_cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_cache_behavior CloudfrontDistribution#default_cache_behavior}
        /// </remarks>
        [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehavior\"}")]
        aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior DefaultCacheBehavior
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#enabled CloudfrontDistribution#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>origin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin CloudfrontDistribution#origin}
        /// </remarks>
        [JsiiProperty(name: "origin", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}]}}")]
        object Origin
        {
            get;
        }

        /// <summary>restrictions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#restrictions CloudfrontDistribution#restrictions}
        /// </remarks>
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictions\"}")]
        aws.Cloudfront.ICloudfrontDistributionRestrictions Restrictions
        {
            get;
        }

        /// <summary>viewer_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#viewer_certificate CloudfrontDistribution#viewer_certificate}
        /// </remarks>
        [JsiiProperty(name: "viewerCertificate", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionViewerCertificate\"}")]
        aws.Cloudfront.ICloudfrontDistributionViewerCertificate ViewerCertificate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#aliases CloudfrontDistribution#aliases}.</summary>
        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Aliases
        {
            get
            {
                return null;
            }
        }

        /// <summary>cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cache_behavior CloudfrontDistribution#cache_behavior}
        /// </remarks>
        [JsiiProperty(name: "cacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CacheBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#comment CloudfrontDistribution#comment}.</summary>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_error_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_error_response CloudfrontDistribution#custom_error_response}
        /// </remarks>
        [JsiiProperty(name: "customErrorResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomErrorResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_root_object CloudfrontDistribution#default_root_object}.</summary>
        [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultRootObject
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#http_version CloudfrontDistribution#http_version}.</summary>
        [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#is_ipv6_enabled CloudfrontDistribution#is_ipv6_enabled}.</summary>
        [JsiiProperty(name: "isIpv6Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsIpv6Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#logging_config CloudfrontDistribution#logging_config}
        /// </remarks>
        [JsiiProperty(name: "loggingConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionLoggingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontDistributionLoggingConfig? LoggingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>ordered_cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#ordered_cache_behavior CloudfrontDistribution#ordered_cache_behavior}
        /// </remarks>
        [JsiiProperty(name: "orderedCacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OrderedCacheBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>origin_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_group CloudfrontDistribution#origin_group}
        /// </remarks>
        [JsiiProperty(name: "originGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OriginGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#price_class CloudfrontDistribution#price_class}.</summary>
        [JsiiProperty(name: "priceClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PriceClass
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#retain_on_delete CloudfrontDistribution#retain_on_delete}.</summary>
        [JsiiProperty(name: "retainOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RetainOnDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#tags CloudfrontDistribution#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#wait_for_deployment CloudfrontDistribution#wait_for_deployment}.</summary>
        [JsiiProperty(name: "waitForDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WaitForDeployment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#web_acl_id CloudfrontDistribution#web_acl_id}.</summary>
        [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebAclId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CloudFront.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_cache_behavior block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_cache_behavior CloudfrontDistribution#default_cache_behavior}
            /// </remarks>
            [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehavior\"}")]
            public aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior DefaultCacheBehavior
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#enabled CloudfrontDistribution#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>origin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin CloudfrontDistribution#origin}
            /// </remarks>
            [JsiiProperty(name: "origin", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}]}}")]
            public object Origin
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>restrictions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#restrictions CloudfrontDistribution#restrictions}
            /// </remarks>
            [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictions\"}")]
            public aws.Cloudfront.ICloudfrontDistributionRestrictions Restrictions
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionRestrictions>()!;
            }

            /// <summary>viewer_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#viewer_certificate CloudfrontDistribution#viewer_certificate}
            /// </remarks>
            [JsiiProperty(name: "viewerCertificate", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionViewerCertificate\"}")]
            public aws.Cloudfront.ICloudfrontDistributionViewerCertificate ViewerCertificate
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionViewerCertificate>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#aliases CloudfrontDistribution#aliases}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Aliases
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>cache_behavior block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cache_behavior CloudfrontDistribution#cache_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CacheBehavior
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#comment CloudfrontDistribution#comment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>custom_error_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_error_response CloudfrontDistribution#custom_error_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customErrorResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomErrorResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_root_object CloudfrontDistribution#default_root_object}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultRootObject
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#http_version CloudfrontDistribution#http_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#is_ipv6_enabled CloudfrontDistribution#is_ipv6_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isIpv6Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsIpv6Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>logging_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#logging_config CloudfrontDistribution#logging_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loggingConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionLoggingConfig\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontDistributionLoggingConfig? LoggingConfig
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionLoggingConfig?>();
            }

            /// <summary>ordered_cache_behavior block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#ordered_cache_behavior CloudfrontDistribution#ordered_cache_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderedCacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OrderedCacheBehavior
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>origin_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_group CloudfrontDistribution#origin_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OriginGroup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#price_class CloudfrontDistribution#price_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priceClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PriceClass
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#retain_on_delete CloudfrontDistribution#retain_on_delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retainOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RetainOnDelete
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#tags CloudfrontDistribution#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#wait_for_deployment CloudfrontDistribution#wait_for_deployment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitForDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? WaitForDeployment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#web_acl_id CloudfrontDistribution#web_acl_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebAclId
            {
                get => GetInstanceProperty<string?>();
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
