using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionOriginGroupMember")]
    public class CloudfrontDistributionOriginGroupMember : aws.Cloudfront.ICloudfrontDistributionOriginGroupMember
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        public string OriginId
        {
            get;
            set;
        }
    }
}
