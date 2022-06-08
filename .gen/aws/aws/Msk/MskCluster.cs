using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster aws_msk_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.Msk.MskCluster), fullyQualifiedName: "aws.msk.MskCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.msk.MskClusterConfig\"}}]")]
    public class MskCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster aws_msk_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MskCluster(Constructs.Construct scope, string id, aws.Msk.IMskClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBrokerNodeGroupInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterBrokerNodeGroupInfo\"}}]")]
        public virtual void PutBrokerNodeGroupInfo(aws.Msk.IMskClusterBrokerNodeGroupInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterBrokerNodeGroupInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterClientAuthentication\"}}]")]
        public virtual void PutClientAuthentication(aws.Msk.IMskClusterClientAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterClientAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfigurationInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterConfigurationInfo\"}}]")]
        public virtual void PutConfigurationInfo(aws.Msk.IMskClusterConfigurationInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterConfigurationInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterEncryptionInfo\"}}]")]
        public virtual void PutEncryptionInfo(aws.Msk.IMskClusterEncryptionInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterEncryptionInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoggingInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterLoggingInfo\"}}]")]
        public virtual void PutLoggingInfo(aws.Msk.IMskClusterLoggingInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterLoggingInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenMonitoring", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterOpenMonitoring\"}}]")]
        public virtual void PutOpenMonitoring(aws.Msk.IMskClusterOpenMonitoring @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterOpenMonitoring)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientAuthentication")]
        public virtual void ResetClientAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurationInfo")]
        public virtual void ResetConfigurationInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionInfo")]
        public virtual void ResetEncryptionInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnhancedMonitoring")]
        public virtual void ResetEnhancedMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingInfo")]
        public virtual void ResetLoggingInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenMonitoring")]
        public virtual void ResetOpenMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.Msk.MskCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokers", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokers
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterBrokerNodeGroupInfoOutputReference\"}")]
        public virtual aws.Msk.MskClusterBrokerNodeGroupInfoOutputReference BrokerNodeGroupInfo
        {
            get => GetInstanceProperty<aws.Msk.MskClusterBrokerNodeGroupInfoOutputReference>()!;
        }

        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationOutputReference\"}")]
        public virtual aws.Msk.MskClusterClientAuthenticationOutputReference ClientAuthentication
        {
            get => GetInstanceProperty<aws.Msk.MskClusterClientAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "configurationInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterConfigurationInfoOutputReference\"}")]
        public virtual aws.Msk.MskClusterConfigurationInfoOutputReference ConfigurationInfo
        {
            get => GetInstanceProperty<aws.Msk.MskClusterConfigurationInfoOutputReference>()!;
        }

        [JsiiProperty(name: "currentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfoOutputReference\"}")]
        public virtual aws.Msk.MskClusterEncryptionInfoOutputReference EncryptionInfo
        {
            get => GetInstanceProperty<aws.Msk.MskClusterEncryptionInfoOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loggingInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoOutputReference\"}")]
        public virtual aws.Msk.MskClusterLoggingInfoOutputReference LoggingInfo
        {
            get => GetInstanceProperty<aws.Msk.MskClusterLoggingInfoOutputReference>()!;
        }

        [JsiiProperty(name: "openMonitoring", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringOutputReference\"}")]
        public virtual aws.Msk.MskClusterOpenMonitoringOutputReference OpenMonitoring
        {
            get => GetInstanceProperty<aws.Msk.MskClusterOpenMonitoringOutputReference>()!;
        }

        [JsiiProperty(name: "zookeeperConnectString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZookeeperConnectString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerNodeGroupInfoInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterBrokerNodeGroupInfo\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterBrokerNodeGroupInfo? BrokerNodeGroupInfoInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterBrokerNodeGroupInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAuthenticationInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthentication\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterClientAuthentication? ClientAuthenticationInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterClientAuthentication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInfoInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterConfigurationInfo\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterConfigurationInfo? ConfigurationInfoInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterConfigurationInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInfoInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfo\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterEncryptionInfo? EncryptionInfoInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterEncryptionInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enhancedMonitoringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnhancedMonitoringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KafkaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInfoInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfo\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterLoggingInfo? LoggingInfoInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfBrokerNodesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfBrokerNodesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openMonitoringInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoring\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterOpenMonitoring? OpenMonitoringInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoring?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnhancedMonitoring
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfBrokerNodes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
