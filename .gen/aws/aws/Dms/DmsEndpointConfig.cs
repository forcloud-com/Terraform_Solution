using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    #pragma warning disable CS8618

    /// <summary>AWS Database Migration Service.</summary>
    [JsiiByValue(fqn: "aws.dms.DmsEndpointConfig")]
    public class DmsEndpointConfig : aws.Dms.IDmsEndpointConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#endpoint_id DmsEndpoint#endpoint_id}.</summary>
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#endpoint_type DmsEndpoint#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#engine_name DmsEndpoint#engine_name}.</summary>
        [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}")]
        public string EngineName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#certificate_arn DmsEndpoint#certificate_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#database_name DmsEndpoint#database_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseName
        {
            get;
            set;
        }

        /// <summary>elasticsearch_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#elasticsearch_settings DmsEndpoint#elasticsearch_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointElasticsearchSettings\"}", isOptional: true)]
        public aws.Dms.IDmsEndpointElasticsearchSettings? ElasticsearchSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#extra_connection_attributes DmsEndpoint#extra_connection_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExtraConnectionAttributes
        {
            get;
            set;
        }

        /// <summary>kafka_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#kafka_settings DmsEndpoint#kafka_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kafkaSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKafkaSettings\"}", isOptional: true)]
        public aws.Dms.IDmsEndpointKafkaSettings? KafkaSettings
        {
            get;
            set;
        }

        /// <summary>kinesis_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#kinesis_settings DmsEndpoint#kinesis_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKinesisSettings\"}", isOptional: true)]
        public aws.Dms.IDmsEndpointKinesisSettings? KinesisSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#kms_key_arn DmsEndpoint#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>mongodb_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#mongodb_settings DmsEndpoint#mongodb_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mongodbSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointMongodbSettings\"}", isOptional: true)]
        public aws.Dms.IDmsEndpointMongodbSettings? MongodbSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#password DmsEndpoint#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#port DmsEndpoint#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>s3_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#s3_settings DmsEndpoint#s3_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Settings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointS3Settings\"}", isOptional: true)]
        public aws.Dms.IDmsEndpointS3Settings? S3Settings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#server_name DmsEndpoint#server_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role DmsEndpoint#service_access_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccessRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#ssl_mode DmsEndpoint#ssl_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#tags DmsEndpoint#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#username DmsEndpoint#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
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
