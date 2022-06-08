using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptions")]
    public class ElasticsearchDomainAdvancedSecurityOptions : aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#internal_user_database_enabled ElasticsearchDomain#internal_user_database_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InternalUserDatabaseEnabled
        {
            get;
            set;
        }

        /// <summary>master_user_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#master_user_options ElasticsearchDomain#master_user_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "masterUserOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions
        {
            get;
            set;
        }
    }
}
