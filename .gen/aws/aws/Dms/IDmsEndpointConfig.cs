using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    /// <summary>AWS Database Migration Service.</summary>
    [JsiiInterface(nativeType: typeof(IDmsEndpointConfig), fullyQualifiedName: "aws.dms.DmsEndpointConfig")]
    public interface IDmsEndpointConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#endpoint_id DmsEndpoint#endpoint_id}.</summary>
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#endpoint_type DmsEndpoint#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#engine_name DmsEndpoint#engine_name}.</summary>
        [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}")]
        string EngineName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#certificate_arn DmsEndpoint#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#database_name DmsEndpoint#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#elasticsearch_settings DmsEndpoint#elasticsearch_settings}
        /// </remarks>
        [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointElasticsearchSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Dms.IDmsEndpointElasticsearchSettings? ElasticsearchSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#extra_connection_attributes DmsEndpoint#extra_connection_attributes}.</summary>
        [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExtraConnectionAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>kafka_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#kafka_settings DmsEndpoint#kafka_settings}
        /// </remarks>
        [JsiiProperty(name: "kafkaSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKafkaSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Dms.IDmsEndpointKafkaSettings? KafkaSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#kinesis_settings DmsEndpoint#kinesis_settings}
        /// </remarks>
        [JsiiProperty(name: "kinesisSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKinesisSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Dms.IDmsEndpointKinesisSettings? KinesisSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#kms_key_arn DmsEndpoint#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>mongodb_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#mongodb_settings DmsEndpoint#mongodb_settings}
        /// </remarks>
        [JsiiProperty(name: "mongodbSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointMongodbSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Dms.IDmsEndpointMongodbSettings? MongodbSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#password DmsEndpoint#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#port DmsEndpoint#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#s3_settings DmsEndpoint#s3_settings}
        /// </remarks>
        [JsiiProperty(name: "s3Settings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointS3Settings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Dms.IDmsEndpointS3Settings? S3Settings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#server_name DmsEndpoint#server_name}.</summary>
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role DmsEndpoint#service_access_role}.</summary>
        [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccessRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#ssl_mode DmsEndpoint#ssl_mode}.</summary>
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#tags DmsEndpoint#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#username DmsEndpoint#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Database Migration Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointConfig), fullyQualifiedName: "aws.dms.DmsEndpointConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Dms.IDmsEndpointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#endpoint_id DmsEndpoint#endpoint_id}.</summary>
            [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#endpoint_type DmsEndpoint#endpoint_type}.</summary>
            [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#engine_name DmsEndpoint#engine_name}.</summary>
            [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}")]
            public string EngineName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#certificate_arn DmsEndpoint#certificate_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#database_name DmsEndpoint#database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>elasticsearch_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#elasticsearch_settings DmsEndpoint#elasticsearch_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointElasticsearchSettings\"}", isOptional: true)]
            public aws.Dms.IDmsEndpointElasticsearchSettings? ElasticsearchSettings
            {
                get => GetInstanceProperty<aws.Dms.IDmsEndpointElasticsearchSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#extra_connection_attributes DmsEndpoint#extra_connection_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExtraConnectionAttributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>kafka_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#kafka_settings DmsEndpoint#kafka_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kafkaSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKafkaSettings\"}", isOptional: true)]
            public aws.Dms.IDmsEndpointKafkaSettings? KafkaSettings
            {
                get => GetInstanceProperty<aws.Dms.IDmsEndpointKafkaSettings?>();
            }

            /// <summary>kinesis_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#kinesis_settings DmsEndpoint#kinesis_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKinesisSettings\"}", isOptional: true)]
            public aws.Dms.IDmsEndpointKinesisSettings? KinesisSettings
            {
                get => GetInstanceProperty<aws.Dms.IDmsEndpointKinesisSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#kms_key_arn DmsEndpoint#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>mongodb_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#mongodb_settings DmsEndpoint#mongodb_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mongodbSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointMongodbSettings\"}", isOptional: true)]
            public aws.Dms.IDmsEndpointMongodbSettings? MongodbSettings
            {
                get => GetInstanceProperty<aws.Dms.IDmsEndpointMongodbSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#password DmsEndpoint#password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#port DmsEndpoint#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>s3_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#s3_settings DmsEndpoint#s3_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Settings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointS3Settings\"}", isOptional: true)]
            public aws.Dms.IDmsEndpointS3Settings? S3Settings
            {
                get => GetInstanceProperty<aws.Dms.IDmsEndpointS3Settings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#server_name DmsEndpoint#server_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role DmsEndpoint#service_access_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccessRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#ssl_mode DmsEndpoint#ssl_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#tags DmsEndpoint#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#username DmsEndpoint#username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
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
