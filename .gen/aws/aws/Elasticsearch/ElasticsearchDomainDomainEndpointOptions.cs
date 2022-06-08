using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainDomainEndpointOptions")]
    public class ElasticsearchDomainDomainEndpointOptions : aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enforce_https ElasticsearchDomain#enforce_https}.</summary>
        [JsiiProperty(name: "enforceHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object EnforceHttps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#tls_security_policy ElasticsearchDomain#tls_security_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsSecurityPolicy
        {
            get;
            set;
        }
    }
}
