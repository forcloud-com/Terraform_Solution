using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain aws_elasticsearch_domain}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.ElasticsearchDomain), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainConfig\"}}]")]
    public class ElasticsearchDomain : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain aws_elasticsearch_domain} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticsearchDomain(Constructs.Construct scope, string id, aws.Elasticsearch.IElasticsearchDomainConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomain(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdvancedSecurityOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptions\"}}]")]
        public virtual void PutAdvancedSecurityOptions(aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClusterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfig\"}}]")]
        public virtual void PutClusterConfig(aws.Elasticsearch.IElasticsearchDomainClusterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainClusterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCognitoOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainCognitoOptions\"}}]")]
        public virtual void PutCognitoOptions(aws.Elasticsearch.IElasticsearchDomainCognitoOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainCognitoOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDomainEndpointOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainDomainEndpointOptions\"}}]")]
        public virtual void PutDomainEndpointOptions(aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEbsOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEbsOptions\"}}]")]
        public virtual void PutEbsOptions(aws.Elasticsearch.IElasticsearchDomainEbsOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainEbsOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptAtRest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEncryptAtRest\"}}]")]
        public virtual void PutEncryptAtRest(aws.Elasticsearch.IElasticsearchDomainEncryptAtRest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainEncryptAtRest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeToNodeEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainNodeToNodeEncryption\"}}]")]
        public virtual void PutNodeToNodeEncryption(aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshotOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSnapshotOptions\"}}]")]
        public virtual void PutSnapshotOptions(aws.Elasticsearch.IElasticsearchDomainSnapshotOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainSnapshotOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Elasticsearch.IElasticsearchDomainTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainVpcOptions\"}}]")]
        public virtual void PutVpcOptions(aws.Elasticsearch.IElasticsearchDomainVpcOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainVpcOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessPolicies")]
        public virtual void ResetAccessPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdvancedOptions")]
        public virtual void ResetAdvancedOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdvancedSecurityOptions")]
        public virtual void ResetAdvancedSecurityOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterConfig")]
        public virtual void ResetClusterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCognitoOptions")]
        public virtual void ResetCognitoOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomainEndpointOptions")]
        public virtual void ResetDomainEndpointOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsOptions")]
        public virtual void ResetEbsOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchVersion")]
        public virtual void ResetElasticsearchVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptAtRest")]
        public virtual void ResetEncryptAtRest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogPublishingOptions")]
        public virtual void ResetLogPublishingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeToNodeEncryption")]
        public virtual void ResetNodeToNodeEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotOptions")]
        public virtual void ResetSnapshotOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcOptions")]
        public virtual void ResetVpcOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Elasticsearch.ElasticsearchDomain))!;

        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsOutputReference AdvancedSecurityOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfigOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainClusterConfigOutputReference ClusterConfig
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainClusterConfigOutputReference>()!;
        }

        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainCognitoOptionsOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainCognitoOptionsOutputReference CognitoOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainCognitoOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainDomainEndpointOptionsOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainDomainEndpointOptionsOutputReference DomainEndpointOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainDomainEndpointOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEbsOptionsOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainEbsOptionsOutputReference EbsOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainEbsOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEncryptAtRestOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainEncryptAtRestOutputReference EncryptAtRest
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainEncryptAtRestOutputReference>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kibanaEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KibanaEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainNodeToNodeEncryptionOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainNodeToNodeEncryptionOutputReference NodeToNodeEncryption
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainNodeToNodeEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSnapshotOptionsOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainSnapshotOptionsOutputReference SnapshotOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainSnapshotOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainTimeoutsOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainVpcOptionsOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainVpcOptionsOutputReference VpcOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainVpcOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessPoliciesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessPoliciesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdvancedOptionsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions? AdvancedSecurityOptionsInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterConfigInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfig\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainClusterConfig? ClusterConfigInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainClusterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitoOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainCognitoOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainCognitoOptions? CognitoOptionsInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainCognitoOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainEndpointOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainDomainEndpointOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions? DomainEndpointOptionsInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEbsOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainEbsOptions? EbsOptionsInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainEbsOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ElasticsearchVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptAtRestInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainEncryptAtRest\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainEncryptAtRest? EncryptAtRestInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainEncryptAtRest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logPublishingOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogPublishingOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeToNodeEncryptionInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainNodeToNodeEncryption\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption? NodeToNodeEncryptionInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainNodeToNodeEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSnapshotOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainSnapshotOptions? SnapshotOptionsInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainSnapshotOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainTimeouts\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainVpcOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainVpcOptions? VpcOptionsInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainVpcOptions?>();
        }

        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPolicies
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdvancedOptions
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticsearchVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}")]
        public virtual object LogPublishingOptions
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
