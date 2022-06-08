using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/elasticsearch_domain aws_elasticsearch_domain}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.DataAwsElasticsearchDomain), fullyQualifiedName: "aws.elasticsearch.DataAwsElasticsearchDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainConfig\"}}]")]
    public class DataAwsElasticsearchDomain : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/elasticsearch_domain aws_elasticsearch_domain} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsElasticsearchDomain(Constructs.Construct scope, string id, aws.Elasticsearch.IDataAwsElasticsearchDomainConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomain(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "advancedOptions", returnsJson: "{\"type\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"cdktf.IResolvable\"}]}}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual object AdvancedOptions(string key)
        {
            return InvokeInstanceMethod<object>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.Elasticsearch.DataAwsElasticsearchDomain))!;

        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPolicies
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainAdvancedSecurityOptionsList\"}")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainAdvancedSecurityOptionsList AdvancedSecurityOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.DataAwsElasticsearchDomainAdvancedSecurityOptionsList>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainClusterConfigList\"}")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainClusterConfigList ClusterConfig
        {
            get => GetInstanceProperty<aws.Elasticsearch.DataAwsElasticsearchDomainClusterConfigList>()!;
        }

        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainCognitoOptionsList\"}")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainCognitoOptionsList CognitoOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.DataAwsElasticsearchDomainCognitoOptionsList>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Created
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "deleted", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Deleted
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainEbsOptionsList\"}")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainEbsOptionsList EbsOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.DataAwsElasticsearchDomainEbsOptionsList>()!;
        }

        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticsearchVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainEncryptionAtRestList\"}")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainEncryptionAtRestList EncryptionAtRest
        {
            get => GetInstanceProperty<aws.Elasticsearch.DataAwsElasticsearchDomainEncryptionAtRestList>()!;
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

        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainLogPublishingOptionsList\"}")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainLogPublishingOptionsList LogPublishingOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.DataAwsElasticsearchDomainLogPublishingOptionsList>()!;
        }

        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainNodeToNodeEncryptionList\"}")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainNodeToNodeEncryptionList NodeToNodeEncryption
        {
            get => GetInstanceProperty<aws.Elasticsearch.DataAwsElasticsearchDomainNodeToNodeEncryptionList>()!;
        }

        [JsiiProperty(name: "processing", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Processing
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainSnapshotOptionsList\"}")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainSnapshotOptionsList SnapshotOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.DataAwsElasticsearchDomainSnapshotOptionsList>()!;
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainVpcOptionsList\"}")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainVpcOptionsList VpcOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.DataAwsElasticsearchDomainVpcOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
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
