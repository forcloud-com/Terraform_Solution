using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainClusterConfigZoneAwarenessConfig), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfig")]
    public interface IElasticsearchDomainClusterConfigZoneAwarenessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#availability_zone_count ElasticsearchDomain#availability_zone_count}.</summary>
        [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AvailabilityZoneCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainClusterConfigZoneAwarenessConfig), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticsearch.IElasticsearchDomainClusterConfigZoneAwarenessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#availability_zone_count ElasticsearchDomain#availability_zone_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AvailabilityZoneCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
