using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    /// <summary>AWS ElasticSearch Service.</summary>
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainConfig), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainConfig")]
    public interface IElasticsearchDomainConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#domain_name ElasticsearchDomain#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#access_policies ElasticsearchDomain#access_policies}.</summary>
        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessPolicies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#advanced_options ElasticsearchDomain#advanced_options}.</summary>
        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>advanced_security_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#advanced_security_options ElasticsearchDomain#advanced_security_options}
        /// </remarks>
        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions? AdvancedSecurityOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cluster_config ElasticsearchDomain#cluster_config}
        /// </remarks>
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainClusterConfig? ClusterConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>cognito_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cognito_options ElasticsearchDomain#cognito_options}
        /// </remarks>
        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainCognitoOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainCognitoOptions? CognitoOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>domain_endpoint_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#domain_endpoint_options ElasticsearchDomain#domain_endpoint_options}
        /// </remarks>
        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainDomainEndpointOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions? DomainEndpointOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#ebs_options ElasticsearchDomain#ebs_options}
        /// </remarks>
        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEbsOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainEbsOptions? EbsOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#elasticsearch_version ElasticsearchDomain#elasticsearch_version}.</summary>
        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElasticsearchVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>encrypt_at_rest block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#encrypt_at_rest ElasticsearchDomain#encrypt_at_rest}
        /// </remarks>
        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEncryptAtRest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainEncryptAtRest? EncryptAtRest
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_publishing_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#log_publishing_options ElasticsearchDomain#log_publishing_options}
        /// </remarks>
        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogPublishingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>node_to_node_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#node_to_node_encryption ElasticsearchDomain#node_to_node_encryption}
        /// </remarks>
        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainNodeToNodeEncryption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption? NodeToNodeEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>snapshot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#snapshot_options ElasticsearchDomain#snapshot_options}
        /// </remarks>
        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSnapshotOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainSnapshotOptions? SnapshotOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#tags ElasticsearchDomain#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#timeouts ElasticsearchDomain#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#vpc_options ElasticsearchDomain#vpc_options}
        /// </remarks>
        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainVpcOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainVpcOptions? VpcOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS ElasticSearch Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainConfig), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticsearch.IElasticsearchDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#domain_name ElasticsearchDomain#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#access_policies ElasticsearchDomain#access_policies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessPolicies
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#advanced_options ElasticsearchDomain#advanced_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>advanced_security_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#advanced_security_options ElasticsearchDomain#advanced_security_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions? AdvancedSecurityOptions
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions?>();
            }

            /// <summary>cluster_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cluster_config ElasticsearchDomain#cluster_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfig\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainClusterConfig? ClusterConfig
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainClusterConfig?>();
            }

            /// <summary>cognito_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cognito_options ElasticsearchDomain#cognito_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainCognitoOptions\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainCognitoOptions? CognitoOptions
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainCognitoOptions?>();
            }

            /// <summary>domain_endpoint_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#domain_endpoint_options ElasticsearchDomain#domain_endpoint_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainDomainEndpointOptions\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions? DomainEndpointOptions
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions?>();
            }

            /// <summary>ebs_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#ebs_options ElasticsearchDomain#ebs_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEbsOptions\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainEbsOptions? EbsOptions
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainEbsOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#elasticsearch_version ElasticsearchDomain#elasticsearch_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElasticsearchVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encrypt_at_rest block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#encrypt_at_rest ElasticsearchDomain#encrypt_at_rest}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEncryptAtRest\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainEncryptAtRest? EncryptAtRest
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainEncryptAtRest?>();
            }

            /// <summary>log_publishing_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#log_publishing_options ElasticsearchDomain#log_publishing_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogPublishingOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>node_to_node_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#node_to_node_encryption ElasticsearchDomain#node_to_node_encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainNodeToNodeEncryption\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption? NodeToNodeEncryption
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption?>();
            }

            /// <summary>snapshot_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#snapshot_options ElasticsearchDomain#snapshot_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSnapshotOptions\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainSnapshotOptions? SnapshotOptions
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainSnapshotOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#tags ElasticsearchDomain#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#timeouts ElasticsearchDomain#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainTimeouts\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainTimeouts?>();
            }

            /// <summary>vpc_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#vpc_options ElasticsearchDomain#vpc_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainVpcOptions\"}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainVpcOptions? VpcOptions
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainVpcOptions?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
