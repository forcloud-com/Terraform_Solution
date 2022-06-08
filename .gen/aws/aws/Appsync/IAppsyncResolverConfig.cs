using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    /// <summary>AWS AppSync.</summary>
    [JsiiInterface(nativeType: typeof(IAppsyncResolverConfig), fullyQualifiedName: "aws.appsync.AppsyncResolverConfig")]
    public interface IAppsyncResolverConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#api_id AppsyncResolver#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#field AppsyncResolver#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        string Field
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#request_template AppsyncResolver#request_template}.</summary>
        [JsiiProperty(name: "requestTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string RequestTemplate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#response_template AppsyncResolver#response_template}.</summary>
        [JsiiProperty(name: "responseTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string ResponseTemplate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#type AppsyncResolver#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>caching_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#caching_config AppsyncResolver#caching_config}
        /// </remarks>
        [JsiiProperty(name: "cachingConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverCachingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncResolverCachingConfig? CachingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#data_source AppsyncResolver#data_source}.</summary>
        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#kind AppsyncResolver#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>pipeline_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#pipeline_config AppsyncResolver#pipeline_config}
        /// </remarks>
        [JsiiProperty(name: "pipelineConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverPipelineConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncResolverPipelineConfig? PipelineConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS AppSync.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAppsyncResolverConfig), fullyQualifiedName: "aws.appsync.AppsyncResolverConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appsync.IAppsyncResolverConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#api_id AppsyncResolver#api_id}.</summary>
            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#field AppsyncResolver#field}.</summary>
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
            public string Field
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#request_template AppsyncResolver#request_template}.</summary>
            [JsiiProperty(name: "requestTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string RequestTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#response_template AppsyncResolver#response_template}.</summary>
            [JsiiProperty(name: "responseTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string ResponseTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#type AppsyncResolver#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>caching_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#caching_config AppsyncResolver#caching_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cachingConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverCachingConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncResolverCachingConfig? CachingConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncResolverCachingConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#data_source AppsyncResolver#data_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#kind AppsyncResolver#kind}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>pipeline_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#pipeline_config AppsyncResolver#pipeline_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverPipelineConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncResolverPipelineConfig? PipelineConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncResolverPipelineConfig?>();
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
