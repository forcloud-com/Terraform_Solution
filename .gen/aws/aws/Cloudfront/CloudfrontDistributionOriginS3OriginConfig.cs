using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionOriginS3OriginConfig")]
    public class CloudfrontDistributionOriginS3OriginConfig : aws.Cloudfront.ICloudfrontDistributionOriginS3OriginConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_access_identity CloudfrontDistribution#origin_access_identity}.</summary>
        [JsiiProperty(name: "originAccessIdentity", typeJson: "{\"primitive\":\"string\"}")]
        public string OriginAccessIdentity
        {
            get;
            set;
        }
    }
}
