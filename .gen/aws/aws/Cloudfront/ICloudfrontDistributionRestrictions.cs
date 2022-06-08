using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionRestrictions), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionRestrictions")]
    public interface ICloudfrontDistributionRestrictions
    {
        /// <summary>geo_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#geo_restriction CloudfrontDistribution#geo_restriction}
        /// </remarks>
        [JsiiProperty(name: "geoRestriction", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictionsGeoRestriction\"}")]
        aws.Cloudfront.ICloudfrontDistributionRestrictionsGeoRestriction GeoRestriction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionRestrictions), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionRestrictions")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>geo_restriction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#geo_restriction CloudfrontDistribution#geo_restriction}
            /// </remarks>
            [JsiiProperty(name: "geoRestriction", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictionsGeoRestriction\"}")]
            public aws.Cloudfront.ICloudfrontDistributionRestrictionsGeoRestriction GeoRestriction
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionRestrictionsGeoRestriction>()!;
            }
        }
    }
}
