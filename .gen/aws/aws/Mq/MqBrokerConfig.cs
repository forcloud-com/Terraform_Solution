using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    #pragma warning disable CS8618

    /// <summary>AWS Managed Message Queue.</summary>
    [JsiiByValue(fqn: "aws.mq.MqBrokerConfig")]
    public class MqBrokerConfig : aws.Mq.IMqBrokerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#broker_name MqBroker#broker_name}.</summary>
        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
        public string BrokerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#engine_type MqBroker#engine_type}.</summary>
        [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
        public string EngineType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#engine_version MqBroker#engine_version}.</summary>
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string EngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#host_instance_type MqBroker#host_instance_type}.</summary>
        [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public string HostInstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#security_groups MqBroker#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroups
        {
            get;
            set;
        }

        /// <summary>user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#user MqBroker#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mq.MqBrokerUser\"},\"kind\":\"array\"}}]}}")]
        public object User
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#apply_immediately MqBroker#apply_immediately}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ApplyImmediately
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#auto_minor_version_upgrade MqBroker#auto_minor_version_upgrade}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoMinorVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#configuration MqBroker#configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"aws.mq.MqBrokerConfiguration\"}", isOptional: true)]
        public aws.Mq.IMqBrokerConfiguration? Configuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#deployment_mode MqBroker#deployment_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeploymentMode
        {
            get;
            set;
        }

        /// <summary>encryption_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#encryption_options MqBroker#encryption_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionOptions", typeJson: "{\"fqn\":\"aws.mq.MqBrokerEncryptionOptions\"}", isOptional: true)]
        public aws.Mq.IMqBrokerEncryptionOptions? EncryptionOptions
        {
            get;
            set;
        }

        /// <summary>logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#logs MqBroker#logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"aws.mq.MqBrokerLogs\"}", isOptional: true)]
        public aws.Mq.IMqBrokerLogs? Logs
        {
            get;
            set;
        }

        /// <summary>maintenance_window_start_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#maintenance_window_start_time MqBroker#maintenance_window_start_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowStartTime", typeJson: "{\"fqn\":\"aws.mq.MqBrokerMaintenanceWindowStartTime\"}", isOptional: true)]
        public aws.Mq.IMqBrokerMaintenanceWindowStartTime? MaintenanceWindowStartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#publicly_accessible MqBroker#publicly_accessible}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PubliclyAccessible
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#subnet_ids MqBroker#subnet_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#tags MqBroker#tags}.</summary>
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
