using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionOriginGroupFailoverCriteria")]
    public class CloudfrontDistributionOriginGroupFailoverCriteria : aws.Cloudfront.ICloudfrontDistributionOriginGroupFailoverCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#status_codes CloudfrontDistribution#status_codes}.</summary>
        [JsiiProperty(name: "statusCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] StatusCodes
        {
            get;
            set;
        }
    }
}
