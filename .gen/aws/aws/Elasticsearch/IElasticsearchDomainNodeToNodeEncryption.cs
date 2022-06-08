using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainNodeToNodeEncryption), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainNodeToNodeEncryption")]
    public interface IElasticsearchDomainNodeToNodeEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainNodeToNodeEncryption), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainNodeToNodeEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
