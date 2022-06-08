using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionOriginGroup")]
    public class CloudfrontDistributionOriginGroup : aws.Cloudfront.ICloudfrontDistributionOriginGroup
    {
        /// <summary>failover_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#failover_criteria CloudfrontDistribution#failover_criteria}
        /// </remarks>
        [JsiiProperty(name: "failoverCriteria", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroupFailoverCriteria\"}")]
        public aws.Cloudfront.ICloudfrontDistributionOriginGroupFailoverCriteria FailoverCriteria
        {
            get;
            set;
        }

        /// <summary>member block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#member CloudfrontDistribution#member}
        /// </remarks>
        [JsiiProperty(name: "member", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}")]
        public object Member
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
    }
}
