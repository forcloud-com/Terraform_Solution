using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionOrigin")]
    public class CloudfrontDistributionOrigin : aws.Cloudfront.ICloudfrontDistributionOrigin
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#domain_name CloudfrontDistribution#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        public string OriginId
        {
            get;
            set;
        }

        /// <summary>custom_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_header CloudfrontDistribution#custom_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomHeader
        {
            get;
            set;
        }

        /// <summary>custom_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_origin_config CloudfrontDistribution#custom_origin_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginCustomOriginConfig\"}", isOptional: true)]
        public aws.Cloudfront.ICloudfrontDistributionOriginCustomOriginConfig? CustomOriginConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_path CloudfrontDistribution#origin_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginPath
        {
            get;
            set;
        }

        /// <summary>s3_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#s3_origin_config CloudfrontDistribution#s3_origin_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginS3OriginConfig\"}", isOptional: true)]
        public aws.Cloudfront.ICloudfrontDistributionOriginS3OriginConfig? S3OriginConfig
        {
            get;
            set;
        }
    }
}
