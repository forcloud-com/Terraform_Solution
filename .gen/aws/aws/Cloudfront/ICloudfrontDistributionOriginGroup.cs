using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginGroup), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOriginGroup")]
    public interface ICloudfrontDistributionOriginGroup
    {
        /// <summary>failover_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#failover_criteria CloudfrontDistribution#failover_criteria}
        /// </remarks>
        [JsiiProperty(name: "failoverCriteria", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroupFailoverCriteria\"}")]
        aws.Cloudfront.ICloudfrontDistributionOriginGroupFailoverCriteria FailoverCriteria
        {
            get;
        }

        /// <summary>member block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#member CloudfrontDistribution#member}
        /// </remarks>
        [JsiiProperty(name: "member", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}")]
        object Member
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        string OriginId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginGroup), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOriginGroup")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionOriginGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>failover_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#failover_criteria CloudfrontDistribution#failover_criteria}
            /// </remarks>
            [JsiiProperty(name: "failoverCriteria", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroupFailoverCriteria\"}")]
            public aws.Cloudfront.ICloudfrontDistributionOriginGroupFailoverCriteria FailoverCriteria
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOriginGroupFailoverCriteria>()!;
            }

            /// <summary>member block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#member CloudfrontDistribution#member}
            /// </remarks>
            [JsiiProperty(name: "member", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}")]
            public object Member
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
            [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
