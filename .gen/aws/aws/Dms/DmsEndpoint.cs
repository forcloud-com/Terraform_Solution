using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint aws_dms_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.Dms.DmsEndpoint), fullyQualifiedName: "aws.dms.DmsEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dms.DmsEndpointConfig\"}}]")]
    public class DmsEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint aws_dms_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DmsEndpoint(Constructs.Construct scope, string id, aws.Dms.IDmsEndpointConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpoint(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putElasticsearchSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dms.DmsEndpointElasticsearchSettings\"}}]")]
        public virtual void PutElasticsearchSettings(aws.Dms.IDmsEndpointElasticsearchSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dms.IDmsEndpointElasticsearchSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafkaSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dms.DmsEndpointKafkaSettings\"}}]")]
        public virtual void PutKafkaSettings(aws.Dms.IDmsEndpointKafkaSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dms.IDmsEndpointKafkaSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dms.DmsEndpointKinesisSettings\"}}]")]
        public virtual void PutKinesisSettings(aws.Dms.IDmsEndpointKinesisSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dms.IDmsEndpointKinesisSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMongodbSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dms.DmsEndpointMongodbSettings\"}}]")]
        public virtual void PutMongodbSettings(aws.Dms.IDmsEndpointMongodbSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dms.IDmsEndpointMongodbSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Settings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dms.DmsEndpointS3Settings\"}}]")]
        public virtual void PutS3Settings(aws.Dms.IDmsEndpointS3Settings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dms.IDmsEndpointS3Settings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificateArn")]
        public virtual void ResetCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseName")]
        public virtual void ResetDatabaseName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchSettings")]
        public virtual void ResetElasticsearchSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtraConnectionAttributes")]
        public virtual void ResetExtraConnectionAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKafkaSettings")]
        public virtual void ResetKafkaSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisSettings")]
        public virtual void ResetKinesisSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMongodbSettings")]
        public virtual void ResetMongodbSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Settings")]
        public virtual void ResetS3Settings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerName")]
        public virtual void ResetServerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceAccessRole")]
        public virtual void ResetServiceAccessRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslMode")]
        public virtual void ResetSslMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsername")]
        public virtual void ResetUsername()
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
        = GetStaticProperty<string>(typeof(aws.Dms.DmsEndpoint))!;

        [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointElasticsearchSettingsOutputReference\"}")]
        public virtual aws.Dms.DmsEndpointElasticsearchSettingsOutputReference ElasticsearchSettings
        {
            get => GetInstanceProperty<aws.Dms.DmsEndpointElasticsearchSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "endpointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kafkaSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKafkaSettingsOutputReference\"}")]
        public virtual aws.Dms.DmsEndpointKafkaSettingsOutputReference KafkaSettings
        {
            get => GetInstanceProperty<aws.Dms.DmsEndpointKafkaSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKinesisSettingsOutputReference\"}")]
        public virtual aws.Dms.DmsEndpointKinesisSettingsOutputReference KinesisSettings
        {
            get => GetInstanceProperty<aws.Dms.DmsEndpointKinesisSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "mongodbSettings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointMongodbSettingsOutputReference\"}")]
        public virtual aws.Dms.DmsEndpointMongodbSettingsOutputReference MongodbSettings
        {
            get => GetInstanceProperty<aws.Dms.DmsEndpointMongodbSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "s3Settings", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointS3SettingsOutputReference\"}")]
        public virtual aws.Dms.DmsEndpointS3SettingsOutputReference S3Settings
        {
            get => GetInstanceProperty<aws.Dms.DmsEndpointS3SettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchSettingsInput", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointElasticsearchSettings\"}", isOptional: true)]
        public virtual aws.Dms.IDmsEndpointElasticsearchSettings? ElasticsearchSettingsInput
        {
            get => GetInstanceProperty<aws.Dms.IDmsEndpointElasticsearchSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EngineNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extraConnectionAttributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExtraConnectionAttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaSettingsInput", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKafkaSettings\"}", isOptional: true)]
        public virtual aws.Dms.IDmsEndpointKafkaSettings? KafkaSettingsInput
        {
            get => GetInstanceProperty<aws.Dms.IDmsEndpointKafkaSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisSettingsInput", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKinesisSettings\"}", isOptional: true)]
        public virtual aws.Dms.IDmsEndpointKinesisSettings? KinesisSettingsInput
        {
            get => GetInstanceProperty<aws.Dms.IDmsEndpointKinesisSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mongodbSettingsInput", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointMongodbSettings\"}", isOptional: true)]
        public virtual aws.Dms.IDmsEndpointMongodbSettings? MongodbSettingsInput
        {
            get => GetInstanceProperty<aws.Dms.IDmsEndpointMongodbSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3SettingsInput", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointS3Settings\"}", isOptional: true)]
        public virtual aws.Dms.IDmsEndpointS3Settings? S3SettingsInput
        {
            get => GetInstanceProperty<aws.Dms.IDmsEndpointS3Settings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceAccessRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtraConnectionAttributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccessRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslMode
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

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
