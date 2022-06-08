using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionRestrictions")]
    public class CloudfrontDistributionRestrictions : aws.Cloudfront.ICloudfrontDistributionRestrictions
    {
        /// <summary>geo_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#geo_restriction CloudfrontDistribution#geo_restriction}
        /// </remarks>
        [JsiiProperty(name: "geoRestriction", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictionsGeoRestriction\"}")]
        public aws.Cloudfront.ICloudfrontDistributionRestrictionsGeoRestriction GeoRestriction
        {
            get;
            set;
        }
    }
}
