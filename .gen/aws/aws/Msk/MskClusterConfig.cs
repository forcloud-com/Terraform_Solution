using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    /// <summary>AWS Managed Streaming for Kafka.</summary>
    [JsiiByValue(fqn: "aws.msk.MskClusterConfig")]
    public class MskClusterConfig : aws.Msk.IMskClusterConfig
    {
        /// <summary>broker_node_group_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#broker_node_group_info MskCluster#broker_node_group_info}
        /// </remarks>
        [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterBrokerNodeGroupInfo\"}")]
        public aws.Msk.IMskClusterBrokerNodeGroupInfo BrokerNodeGroupInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#cluster_name MskCluster#cluster_name}.</summary>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#kafka_version MskCluster#kafka_version}.</summary>
        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string KafkaVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#number_of_broker_nodes MskCluster#number_of_broker_nodes}.</summary>
        [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}")]
        public double NumberOfBrokerNodes
        {
            get;
            set;
        }

        /// <summary>client_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#client_authentication MskCluster#client_authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthentication\"}", isOptional: true)]
        public aws.Msk.IMskClusterClientAuthentication? ClientAuthentication
        {
            get;
            set;
        }

        /// <summary>configuration_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#configuration_info MskCluster#configuration_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configurationInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterConfigurationInfo\"}", isOptional: true)]
        public aws.Msk.IMskClusterConfigurationInfo? ConfigurationInfo
        {
            get;
            set;
        }

        /// <summary>encryption_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#encryption_info MskCluster#encryption_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfo\"}", isOptional: true)]
        public aws.Msk.IMskClusterEncryptionInfo? EncryptionInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enhanced_monitoring MskCluster#enhanced_monitoring}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnhancedMonitoring
        {
            get;
            set;
        }

        /// <summary>logging_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#logging_info MskCluster#logging_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loggingInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfo\"}", isOptional: true)]
        public aws.Msk.IMskClusterLoggingInfo? LoggingInfo
        {
            get;
            set;
        }

        /// <summary>open_monitoring block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#open_monitoring MskCluster#open_monitoring}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openMonitoring", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoring\"}", isOptional: true)]
        public aws.Msk.IMskClusterOpenMonitoring? OpenMonitoring
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#tags MskCluster#tags}.</summary>
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
