using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfig")]
    public class ElasticsearchDomainClusterConfigZoneAwarenessConfig : aws.Elasticsearch.IElasticsearchDomainClusterConfigZoneAwarenessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#availability_zone_count ElasticsearchDomain#availability_zone_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AvailabilityZoneCount
        {
            get;
            set;
        }
    }
}
