using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    /// <summary>AWS Managed Streaming for Kafka.</summary>
    [JsiiInterface(nativeType: typeof(IMskClusterConfig), fullyQualifiedName: "aws.msk.MskClusterConfig")]
    public interface IMskClusterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>broker_node_group_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#broker_node_group_info MskCluster#broker_node_group_info}
        /// </remarks>
        [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterBrokerNodeGroupInfo\"}")]
        aws.Msk.IMskClusterBrokerNodeGroupInfo BrokerNodeGroupInfo
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#cluster_name MskCluster#cluster_name}.</summary>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#kafka_version MskCluster#kafka_version}.</summary>
        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
        string KafkaVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#number_of_broker_nodes MskCluster#number_of_broker_nodes}.</summary>
        [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}")]
        double NumberOfBrokerNodes
        {
            get;
        }

        /// <summary>client_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#client_authentication MskCluster#client_authentication}
        /// </remarks>
        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthentication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterClientAuthentication? ClientAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>configuration_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#configuration_info MskCluster#configuration_info}
        /// </remarks>
        [JsiiProperty(name: "configurationInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterConfigurationInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterConfigurationInfo? ConfigurationInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#encryption_info MskCluster#encryption_info}
        /// </remarks>
        [JsiiProperty(name: "encryptionInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterEncryptionInfo? EncryptionInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enhanced_monitoring MskCluster#enhanced_monitoring}.</summary>
        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnhancedMonitoring
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#logging_info MskCluster#logging_info}
        /// </remarks>
        [JsiiProperty(name: "loggingInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterLoggingInfo? LoggingInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>open_monitoring block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#open_monitoring MskCluster#open_monitoring}
        /// </remarks>
        [JsiiProperty(name: "openMonitoring", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoring\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterOpenMonitoring? OpenMonitoring
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#tags MskCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Managed Streaming for Kafka.</summary>
        [JsiiTypeProxy(nativeType: typeof(IMskClusterConfig), fullyQualifiedName: "aws.msk.MskClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>broker_node_group_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#broker_node_group_info MskCluster#broker_node_group_info}
            /// </remarks>
            [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterBrokerNodeGroupInfo\"}")]
            public aws.Msk.IMskClusterBrokerNodeGroupInfo BrokerNodeGroupInfo
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterBrokerNodeGroupInfo>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#cluster_name MskCluster#cluster_name}.</summary>
            [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#kafka_version MskCluster#kafka_version}.</summary>
            [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string KafkaVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#number_of_broker_nodes MskCluster#number_of_broker_nodes}.</summary>
            [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}")]
            public double NumberOfBrokerNodes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>client_authentication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#client_authentication MskCluster#client_authentication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthentication\"}", isOptional: true)]
            public aws.Msk.IMskClusterClientAuthentication? ClientAuthentication
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterClientAuthentication?>();
            }

            /// <summary>configuration_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#configuration_info MskCluster#configuration_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configurationInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterConfigurationInfo\"}", isOptional: true)]
            public aws.Msk.IMskClusterConfigurationInfo? ConfigurationInfo
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterConfigurationInfo?>();
            }

            /// <summary>encryption_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#encryption_info MskCluster#encryption_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfo\"}", isOptional: true)]
            public aws.Msk.IMskClusterEncryptionInfo? EncryptionInfo
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterEncryptionInfo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enhanced_monitoring MskCluster#enhanced_monitoring}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnhancedMonitoring
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>logging_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#logging_info MskCluster#logging_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loggingInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfo\"}", isOptional: true)]
            public aws.Msk.IMskClusterLoggingInfo? LoggingInfo
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfo?>();
            }

            /// <summary>open_monitoring block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#open_monitoring MskCluster#open_monitoring}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openMonitoring", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoring\"}", isOptional: true)]
            public aws.Msk.IMskClusterOpenMonitoring? OpenMonitoring
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoring?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#tags MskCluster#tags}.</summary>
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
