using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    /// <summary>AWS Managed Message Queue.</summary>
    [JsiiInterface(nativeType: typeof(IMqBrokerConfig), fullyQualifiedName: "aws.mq.MqBrokerConfig")]
    public interface IMqBrokerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#broker_name MqBroker#broker_name}.</summary>
        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
        string BrokerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#engine_type MqBroker#engine_type}.</summary>
        [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
        string EngineType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#engine_version MqBroker#engine_version}.</summary>
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        string EngineVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#host_instance_type MqBroker#host_instance_type}.</summary>
        [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        string HostInstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#security_groups MqBroker#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroups
        {
            get;
        }

        /// <summary>user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#user MqBroker#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mq.MqBrokerUser\"},\"kind\":\"array\"}}]}}")]
        object User
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#apply_immediately MqBroker#apply_immediately}.</summary>
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplyImmediately
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#auto_minor_version_upgrade MqBroker#auto_minor_version_upgrade}.</summary>
        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoMinorVersionUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#configuration MqBroker#configuration}
        /// </remarks>
        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"aws.mq.MqBrokerConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mq.IMqBrokerConfiguration? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#deployment_mode MqBroker#deployment_mode}.</summary>
        [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#encryption_options MqBroker#encryption_options}
        /// </remarks>
        [JsiiProperty(name: "encryptionOptions", typeJson: "{\"fqn\":\"aws.mq.MqBrokerEncryptionOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mq.IMqBrokerEncryptionOptions? EncryptionOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#logs MqBroker#logs}
        /// </remarks>
        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"aws.mq.MqBrokerLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mq.IMqBrokerLogs? Logs
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_window_start_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#maintenance_window_start_time MqBroker#maintenance_window_start_time}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindowStartTime", typeJson: "{\"fqn\":\"aws.mq.MqBrokerMaintenanceWindowStartTime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mq.IMqBrokerMaintenanceWindowStartTime? MaintenanceWindowStartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#publicly_accessible MqBroker#publicly_accessible}.</summary>
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PubliclyAccessible
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#subnet_ids MqBroker#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubnetIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#tags MqBroker#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Managed Message Queue.</summary>
        [JsiiTypeProxy(nativeType: typeof(IMqBrokerConfig), fullyQualifiedName: "aws.mq.MqBrokerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Mq.IMqBrokerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#broker_name MqBroker#broker_name}.</summary>
            [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
            public string BrokerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#engine_type MqBroker#engine_type}.</summary>
            [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
            public string EngineType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#engine_version MqBroker#engine_version}.</summary>
            [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string EngineVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#host_instance_type MqBroker#host_instance_type}.</summary>
            [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string HostInstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#security_groups MqBroker#security_groups}.</summary>
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroups
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#user MqBroker#user}
            /// </remarks>
            [JsiiProperty(name: "user", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mq.MqBrokerUser\"},\"kind\":\"array\"}}]}}")]
            public object User
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#apply_immediately MqBroker#apply_immediately}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ApplyImmediately
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#auto_minor_version_upgrade MqBroker#auto_minor_version_upgrade}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoMinorVersionUpgrade
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#configuration MqBroker#configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"aws.mq.MqBrokerConfiguration\"}", isOptional: true)]
            public aws.Mq.IMqBrokerConfiguration? Configuration
            {
                get => GetInstanceProperty<aws.Mq.IMqBrokerConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#deployment_mode MqBroker#deployment_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encryption_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#encryption_options MqBroker#encryption_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionOptions", typeJson: "{\"fqn\":\"aws.mq.MqBrokerEncryptionOptions\"}", isOptional: true)]
            public aws.Mq.IMqBrokerEncryptionOptions? EncryptionOptions
            {
                get => GetInstanceProperty<aws.Mq.IMqBrokerEncryptionOptions?>();
            }

            /// <summary>logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#logs MqBroker#logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"aws.mq.MqBrokerLogs\"}", isOptional: true)]
            public aws.Mq.IMqBrokerLogs? Logs
            {
                get => GetInstanceProperty<aws.Mq.IMqBrokerLogs?>();
            }

            /// <summary>maintenance_window_start_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#maintenance_window_start_time MqBroker#maintenance_window_start_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindowStartTime", typeJson: "{\"fqn\":\"aws.mq.MqBrokerMaintenanceWindowStartTime\"}", isOptional: true)]
            public aws.Mq.IMqBrokerMaintenanceWindowStartTime? MaintenanceWindowStartTime
            {
                get => GetInstanceProperty<aws.Mq.IMqBrokerMaintenanceWindowStartTime?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#publicly_accessible MqBroker#publicly_accessible}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PubliclyAccessible
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#subnet_ids MqBroker#subnet_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubnetIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#tags MqBroker#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
