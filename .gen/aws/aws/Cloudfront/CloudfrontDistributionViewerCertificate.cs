using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionViewerCertificate")]
    public class CloudfrontDistributionViewerCertificate : aws.Cloudfront.ICloudfrontDistributionViewerCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#acm_certificate_arn CloudfrontDistribution#acm_certificate_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acmCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AcmCertificateArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cloudfront_default_certificate CloudfrontDistribution#cloudfront_default_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudfrontDefaultCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CloudfrontDefaultCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#iam_certificate_id CloudfrontDistribution#iam_certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IamCertificateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#minimum_protocol_version CloudfrontDistribution#minimum_protocol_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumProtocolVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumProtocolVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#ssl_support_method CloudfrontDistribution#ssl_support_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslSupportMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslSupportMethod
        {
            get;
            set;
        }
    }
}
