using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainNodeToNodeEncryption")]
    public class ElasticsearchDomainNodeToNodeEncryption : aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }
    }
}
