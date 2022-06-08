using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    /// <summary>AWS ElasticSearch Service.</summary>
    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainConfig")]
    public class ElasticsearchDomainConfig : aws.Elasticsearch.IElasticsearchDomainConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#domain_name ElasticsearchDomain#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#access_policies ElasticsearchDomain#access_policies}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessPolicies
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#advanced_options ElasticsearchDomain#advanced_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
        {
            get;
            set;
        }

        /// <summary>advanced_security_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#advanced_security_options ElasticsearchDomain#advanced_security_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions? AdvancedSecurityOptions
        {
            get;
            set;
        }

        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cluster_config ElasticsearchDomain#cluster_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfig\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainClusterConfig? ClusterConfig
        {
            get;
            set;
        }

        /// <summary>cognito_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cognito_options ElasticsearchDomain#cognito_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainCognitoOptions\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainCognitoOptions? CognitoOptions
        {
            get;
            set;
        }

        /// <summary>domain_endpoint_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#domain_endpoint_options ElasticsearchDomain#domain_endpoint_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainDomainEndpointOptions\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions? DomainEndpointOptions
        {
            get;
            set;
        }

        /// <summary>ebs_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#ebs_options ElasticsearchDomain#ebs_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEbsOptions\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainEbsOptions? EbsOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#elasticsearch_version ElasticsearchDomain#elasticsearch_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElasticsearchVersion
        {
            get;
            set;
        }

        /// <summary>encrypt_at_rest block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#encrypt_at_rest ElasticsearchDomain#encrypt_at_rest}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEncryptAtRest\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainEncryptAtRest? EncryptAtRest
        {
            get;
            set;
        }

        /// <summary>log_publishing_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#log_publishing_options ElasticsearchDomain#log_publishing_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogPublishingOptions
        {
            get;
            set;
        }

        /// <summary>node_to_node_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#node_to_node_encryption ElasticsearchDomain#node_to_node_encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainNodeToNodeEncryption\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption? NodeToNodeEncryption
        {
            get;
            set;
        }

        /// <summary>snapshot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#snapshot_options ElasticsearchDomain#snapshot_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSnapshotOptions\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainSnapshotOptions? SnapshotOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#tags ElasticsearchDomain#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#timeouts ElasticsearchDomain#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainTimeouts\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>vpc_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#vpc_options ElasticsearchDomain#vpc_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainVpcOptions\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainVpcOptions? VpcOptions
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
