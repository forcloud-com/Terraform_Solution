using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptions")]
    public interface IElasticsearchDomainAdvancedSecurityOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#internal_user_database_enabled ElasticsearchDomain#internal_user_database_enabled}.</summary>
        [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InternalUserDatabaseEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>master_user_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#master_user_options ElasticsearchDomain#master_user_options}
        /// </remarks>
        [JsiiProperty(name: "masterUserOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions
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

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#internal_user_database_enabled ElasticsearchDomain#internal_user_database_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InternalUserDatabaseEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>master_user_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#master_user_options ElasticsearchDomain#master_user_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "masterUserOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions?>();
            }
        }
    }
}
