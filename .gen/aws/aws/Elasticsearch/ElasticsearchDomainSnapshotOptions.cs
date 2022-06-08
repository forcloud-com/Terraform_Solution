using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainSnapshotOptions")]
    public class ElasticsearchDomainSnapshotOptions : aws.Elasticsearch.IElasticsearchDomainSnapshotOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#automated_snapshot_start_hour ElasticsearchDomain#automated_snapshot_start_hour}.</summary>
        [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
        public double AutomatedSnapshotStartHour
        {
            get;
            set;
        }
    }
}
