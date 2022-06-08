using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource aws_appsync_datasource}.</summary>
    [JsiiClass(nativeType: typeof(aws.Appsync.AppsyncDatasource), fullyQualifiedName: "aws.appsync.AppsyncDatasource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appsync.AppsyncDatasourceConfig\"}}]")]
    public class AppsyncDatasource : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource aws_appsync_datasource} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppsyncDatasource(Constructs.Construct scope, string id, aws.Appsync.IAppsyncDatasourceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncDatasource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncDatasource(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDynamodbConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsync.AppsyncDatasourceDynamodbConfig\"}}]")]
        public virtual void PutDynamodbConfig(aws.Appsync.IAppsyncDatasourceDynamodbConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appsync.IAppsyncDatasourceDynamodbConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putElasticsearchConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsync.AppsyncDatasourceElasticsearchConfig\"}}]")]
        public virtual void PutElasticsearchConfig(aws.Appsync.IAppsyncDatasourceElasticsearchConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appsync.IAppsyncDatasourceElasticsearchConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsync.AppsyncDatasourceHttpConfig\"}}]")]
        public virtual void PutHttpConfig(aws.Appsync.IAppsyncDatasourceHttpConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appsync.IAppsyncDatasourceHttpConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsync.AppsyncDatasourceLambdaConfig\"}}]")]
        public virtual void PutLambdaConfig(aws.Appsync.IAppsyncDatasourceLambdaConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appsync.IAppsyncDatasourceLambdaConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbConfig")]
        public virtual void ResetDynamodbConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchConfig")]
        public virtual void ResetElasticsearchConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpConfig")]
        public virtual void ResetHttpConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaConfig")]
        public virtual void ResetLambdaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRoleArn")]
        public virtual void ResetServiceRoleArn()
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
        = GetStaticProperty<string>(typeof(aws.Appsync.AppsyncDatasource))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceDynamodbConfigOutputReference\"}")]
        public virtual aws.Appsync.AppsyncDatasourceDynamodbConfigOutputReference DynamodbConfig
        {
            get => GetInstanceProperty<aws.Appsync.AppsyncDatasourceDynamodbConfigOutputReference>()!;
        }

        [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceElasticsearchConfigOutputReference\"}")]
        public virtual aws.Appsync.AppsyncDatasourceElasticsearchConfigOutputReference ElasticsearchConfig
        {
            get => GetInstanceProperty<aws.Appsync.AppsyncDatasourceElasticsearchConfigOutputReference>()!;
        }

        [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceHttpConfigOutputReference\"}")]
        public virtual aws.Appsync.AppsyncDatasourceHttpConfigOutputReference HttpConfig
        {
            get => GetInstanceProperty<aws.Appsync.AppsyncDatasourceHttpConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceLambdaConfigOutputReference\"}")]
        public virtual aws.Appsync.AppsyncDatasourceLambdaConfigOutputReference LambdaConfig
        {
            get => GetInstanceProperty<aws.Appsync.AppsyncDatasourceLambdaConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbConfigInput", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceDynamodbConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncDatasourceDynamodbConfig? DynamodbConfigInput
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncDatasourceDynamodbConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchConfigInput", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceElasticsearchConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncDatasourceElasticsearchConfig? ElasticsearchConfigInput
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncDatasourceElasticsearchConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpConfigInput", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceHttpConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncDatasourceHttpConfig? HttpConfigInput
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncDatasourceHttpConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfigInput", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceLambdaConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncDatasourceLambdaConfig? LambdaConfigInput
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncDatasourceLambdaConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
