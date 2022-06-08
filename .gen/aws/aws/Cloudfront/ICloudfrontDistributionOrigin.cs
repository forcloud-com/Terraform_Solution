using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOrigin), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrigin")]
    public interface ICloudfrontDistributionOrigin
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#domain_name CloudfrontDistribution#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        string OriginId
        {
            get;
        }

        /// <summary>custom_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_header CloudfrontDistribution#custom_header}
        /// </remarks>
        [JsiiProperty(name: "customHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_origin_config CloudfrontDistribution#custom_origin_config}
        /// </remarks>
        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginCustomOriginConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontDistributionOriginCustomOriginConfig? CustomOriginConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_path CloudfrontDistribution#origin_path}.</summary>
        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#s3_origin_config CloudfrontDistribution#s3_origin_config}
        /// </remarks>
        [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginS3OriginConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontDistributionOriginS3OriginConfig? S3OriginConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOrigin), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrigin")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionOrigin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#domain_name CloudfrontDistribution#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
            [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_header CloudfrontDistribution#custom_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_origin_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_origin_config CloudfrontDistribution#custom_origin_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginCustomOriginConfig\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontDistributionOriginCustomOriginConfig? CustomOriginConfig
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOriginCustomOriginConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_path CloudfrontDistribution#origin_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>s3_origin_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#s3_origin_config CloudfrontDistribution#s3_origin_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginS3OriginConfig\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontDistributionOriginS3OriginConfig? S3OriginConfig
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOriginS3OriginConfig?>();
            }
        }
    }
}
