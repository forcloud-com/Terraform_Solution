using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.ElasticsearchDomainSnapshotOptionsOutputReference), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainSnapshotOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElasticsearchDomainSnapshotOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElasticsearchDomainSnapshotOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainSnapshotOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainSnapshotOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "automatedSnapshotStartHourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutomatedSnapshotStartHourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutomatedSnapshotStartHour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSnapshotOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainSnapshotOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainSnapshotOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
