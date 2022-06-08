using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginGroupFailoverCriteria), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOriginGroupFailoverCriteria")]
    public interface ICloudfrontDistributionOriginGroupFailoverCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#status_codes CloudfrontDistribution#status_codes}.</summary>
        [JsiiProperty(name: "statusCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] StatusCodes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginGroupFailoverCriteria), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOriginGroupFailoverCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionOriginGroupFailoverCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#status_codes CloudfrontDistribution#status_codes}.</summary>
            [JsiiProperty(name: "statusCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] StatusCodes
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
