using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    /// <summary>AWS AppSync.</summary>
    [JsiiByValue(fqn: "aws.appsync.AppsyncDatasourceConfig")]
    public class AppsyncDatasourceConfig : aws.Appsync.IAppsyncDatasourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#api_id AppsyncDatasource#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#name AppsyncDatasource#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#type AppsyncDatasource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#description AppsyncDatasource#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>dynamodb_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#dynamodb_config AppsyncDatasource#dynamodb_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceDynamodbConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncDatasourceDynamodbConfig? DynamodbConfig
        {
            get;
            set;
        }

        /// <summary>elasticsearch_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#elasticsearch_config AppsyncDatasource#elasticsearch_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceElasticsearchConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncDatasourceElasticsearchConfig? ElasticsearchConfig
        {
            get;
            set;
        }

        /// <summary>http_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#http_config AppsyncDatasource#http_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceHttpConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncDatasourceHttpConfig? HttpConfig
        {
            get;
            set;
        }

        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#lambda_config AppsyncDatasource#lambda_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncDatasourceLambdaConfig\"}", isOptional: true)]
        public aws.Appsync.IAppsyncDatasourceLambdaConfig? LambdaConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#service_role_arn AppsyncDatasource#service_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceRoleArn
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
