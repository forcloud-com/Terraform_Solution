using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainSnapshotOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainSnapshotOptions")]
    public interface IElasticsearchDomainSnapshotOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#automated_snapshot_start_hour ElasticsearchDomain#automated_snapshot_start_hour}.</summary>
        [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
        double AutomatedSnapshotStartHour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainSnapshotOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainSnapshotOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticsearch.IElasticsearchDomainSnapshotOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#automated_snapshot_start_hour ElasticsearchDomain#automated_snapshot_start_hour}.</summary>
            [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
            public double AutomatedSnapshotStartHour
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
