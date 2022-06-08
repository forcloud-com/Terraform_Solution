using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginS3OriginConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOriginS3OriginConfig")]
    public interface ICloudfrontDistributionOriginS3OriginConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_access_identity CloudfrontDistribution#origin_access_identity}.</summary>
        [JsiiProperty(name: "originAccessIdentity", typeJson: "{\"primitive\":\"string\"}")]
        string OriginAccessIdentity
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginS3OriginConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOriginS3OriginConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionOriginS3OriginConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_access_identity CloudfrontDistribution#origin_access_identity}.</summary>
            [JsiiProperty(name: "originAccessIdentity", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginAccessIdentity
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
