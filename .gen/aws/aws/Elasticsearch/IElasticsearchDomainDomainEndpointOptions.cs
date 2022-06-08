using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainDomainEndpointOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainDomainEndpointOptions")]
    public interface IElasticsearchDomainDomainEndpointOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enforce_https ElasticsearchDomain#enforce_https}.</summary>
        [JsiiProperty(name: "enforceHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object EnforceHttps
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#tls_security_policy ElasticsearchDomain#tls_security_policy}.</summary>
        [JsiiProperty(name: "tlsSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsSecurityPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainDomainEndpointOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainDomainEndpointOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enforce_https ElasticsearchDomain#enforce_https}.</summary>
            [JsiiProperty(name: "enforceHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object EnforceHttps
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#tls_security_policy ElasticsearchDomain#tls_security_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsSecurityPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
