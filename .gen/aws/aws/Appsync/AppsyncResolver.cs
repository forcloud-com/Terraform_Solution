using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver aws_appsync_resolver}.</summary>
    [JsiiClass(nativeType: typeof(aws.Appsync.AppsyncResolver), fullyQualifiedName: "aws.appsync.AppsyncResolver", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appsync.AppsyncResolverConfig\"}}]")]
    public class AppsyncResolver : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver aws_appsync_resolver} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppsyncResolver(Constructs.Construct scope, string id, aws.Appsync.IAppsyncResolverConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncResolver(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncResolver(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCachingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsync.AppsyncResolverCachingConfig\"}}]")]
        public virtual void PutCachingConfig(aws.Appsync.IAppsyncResolverCachingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appsync.IAppsyncResolverCachingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPipelineConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsync.AppsyncResolverPipelineConfig\"}}]")]
        public virtual void PutPipelineConfig(aws.Appsync.IAppsyncResolverPipelineConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appsync.IAppsyncResolverPipelineConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCachingConfig")]
        public virtual void ResetCachingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataSource")]
        public virtual void ResetDataSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKind")]
        public virtual void ResetKind()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPipelineConfig")]
        public virtual void ResetPipelineConfig()
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
        = GetStaticProperty<string>(typeof(aws.Appsync.AppsyncResolver))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cachingConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverCachingConfigOutputReference\"}")]
        public virtual aws.Appsync.AppsyncResolverCachingConfigOutputReference CachingConfig
        {
            get => GetInstanceProperty<aws.Appsync.AppsyncResolverCachingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pipelineConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverPipelineConfigOutputReference\"}")]
        public virtual aws.Appsync.AppsyncResolverPipelineConfigOutputReference PipelineConfig
        {
            get => GetInstanceProperty<aws.Appsync.AppsyncResolverPipelineConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachingConfigInput", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverCachingConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncResolverCachingConfig? CachingConfigInput
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncResolverCachingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineConfigInput", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverPipelineConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncResolverPipelineConfig? PipelineConfigInput
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncResolverPipelineConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseTemplateInput
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

        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Field
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseTemplate
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
