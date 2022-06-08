using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    /// <summary>AWS AppSync.</summary>
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceConfig), fullyQualifiedName: "aws.appsync.AppsyncDatasourceConfig")]
    public interface IAppsyncDatasourceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#api_id AppsyncDatasource#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#name AppsyncDatasource#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#type AppsyncDatasource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#description AppsyncDatasource#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodb_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#dynamodb_config AppsyncDatasource#dynamodb_config}
        /// </remarks>
        [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceDynamodbConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncDatasourceDynamodbConfig? DynamodbConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#elasticsearch_config AppsyncDatasource#elasticsearch_config}
        /// </remarks>
        [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceElasticsearchConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncDatasourceElasticsearchConfig? ElasticsearchConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#http_config AppsyncDatasource#http_config}
        /// </remarks>
        [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceHttpConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncDatasourceHttpConfig? HttpConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#lambda_config AppsyncDatasource#lambda_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceLambdaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appsync.IAppsyncDatasourceLambdaConfig? LambdaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#service_role_arn AppsyncDatasource#service_role_arn}.</summary>
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS AppSync.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceConfig), fullyQualifiedName: "aws.appsync.AppsyncDatasourceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appsync.IAppsyncDatasourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#api_id AppsyncDatasource#api_id}.</summary>
            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#name AppsyncDatasource#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#type AppsyncDatasource#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#description AppsyncDatasource#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dynamodb_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#dynamodb_config AppsyncDatasource#dynamodb_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceDynamodbConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncDatasourceDynamodbConfig? DynamodbConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncDatasourceDynamodbConfig?>();
            }

            /// <summary>elasticsearch_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#elasticsearch_config AppsyncDatasource#elasticsearch_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceElasticsearchConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncDatasourceElasticsearchConfig? ElasticsearchConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncDatasourceElasticsearchConfig?>();
            }

            /// <summary>http_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#http_config AppsyncDatasource#http_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceHttpConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncDatasourceHttpConfig? HttpConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncDatasourceHttpConfig?>();
            }

            /// <summary>lambda_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#lambda_config AppsyncDatasource#lambda_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceLambdaConfig\"}", isOptional: true)]
            public aws.Appsync.IAppsyncDatasourceLambdaConfig? LambdaConfig
            {
                get => GetInstanceProperty<aws.Appsync.IAppsyncDatasourceLambdaConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#service_role_arn AppsyncDatasource#service_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceRoleArn
            {
                get => GetInstanceProperty<string?>();
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
