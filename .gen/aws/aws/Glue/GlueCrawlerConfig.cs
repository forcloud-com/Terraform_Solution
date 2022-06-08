using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    /// <summary>AWS Glue.</summary>
    [JsiiByValue(fqn: "aws.glue.GlueCrawlerConfig")]
    public class GlueCrawlerConfig : aws.Glue.IGlueCrawlerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#database_name GlueCrawler#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#name GlueCrawler#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#role GlueCrawler#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public string Role
        {
            get;
            set;
        }

        /// <summary>catalog_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#catalog_target GlueCrawler#catalog_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "catalogTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CatalogTarget
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#classifiers GlueCrawler#classifiers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "classifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Classifiers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#configuration GlueCrawler#configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Configuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#description GlueCrawler#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>dynamodb_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#dynamodb_target GlueCrawler#dynamodb_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodbTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DynamodbTarget
        {
            get;
            set;
        }

        /// <summary>jdbc_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#jdbc_target GlueCrawler#jdbc_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jdbcTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? JdbcTarget
        {
            get;
            set;
        }

        /// <summary>s3_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#s3_target GlueCrawler#s3_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Target", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerS3Target\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Target
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#schedule GlueCrawler#schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Schedule
        {
            get;
            set;
        }

        /// <summary>schema_change_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#schema_change_policy GlueCrawler#schema_change_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemaChangePolicy", typeJson: "{\"fqn\":\"aws.glue.GlueCrawlerSchemaChangePolicy\"}", isOptional: true)]
        public aws.Glue.IGlueCrawlerSchemaChangePolicy? SchemaChangePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#security_configuration GlueCrawler#security_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#table_prefix GlueCrawler#table_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TablePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#tags GlueCrawler#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
