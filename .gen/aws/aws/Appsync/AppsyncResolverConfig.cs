using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    /// <summary>AWS AppSync.</summary>
    [JsiiByValue(fqn: "aws.appsync.AppsyncResolverConfig")]
    public class AppsyncResolverConfig : aws.Appsync.IAppsyncResolverConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#api_id AppsyncResolver#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#field AppsyncResolver#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public string Field
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#request_template AppsyncResolver#request_template}.</summary>
        [JsiiProperty(name: "requestTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public string RequestTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#response_template AppsyncResolver#response_template}.</summary>
        [JsiiProperty(name: "responseTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public string ResponseTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#type AppsyncResolver#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>caching_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#caching_config AppsyncResolver#caching_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cachingConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverCachingConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncResolverCachingConfig? CachingConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#data_source AppsyncResolver#data_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#kind AppsyncResolver#kind}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kind
        {
            get;
            set;
        }

        /// <summary>pipeline_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#pipeline_config AppsyncResolver#pipeline_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncResolverPipelineConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncResolverPipelineConfig? PipelineConfig
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
