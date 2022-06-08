using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance aws_opsworks_instance}.</summary>
    [JsiiClass(nativeType: typeof(aws.Opsworks.OpsworksInstance), fullyQualifiedName: "aws.opsworks.OpsworksInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.opsworks.OpsworksInstanceConfig\"}}]")]
    public class OpsworksInstance : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance aws_opsworks_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OpsworksInstance(Constructs.Construct scope, string id, aws.Opsworks.IOpsworksInstanceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksInstance(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opsworks.OpsworksInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Opsworks.IOpsworksInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Opsworks.IOpsworksInstanceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentVersion")]
        public virtual void ResetAgentVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAmiId")]
        public virtual void ResetAmiId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetArchitecture")]
        public virtual void ResetArchitecture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoScalingType")]
        public virtual void ResetAutoScalingType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityZone")]
        public virtual void ResetAvailabilityZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreatedAt")]
        public virtual void ResetCreatedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteEbs")]
        public virtual void ResetDeleteEbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteEip")]
        public virtual void ResetDeleteEip()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsBlockDevice")]
        public virtual void ResetEbsBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsOptimized")]
        public virtual void ResetEbsOptimized()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsClusterArn")]
        public virtual void ResetEcsClusterArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticIp")]
        public virtual void ResetElasticIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEphemeralBlockDevice")]
        public virtual void ResetEphemeralBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostname")]
        public virtual void ResetHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInfrastructureClass")]
        public virtual void ResetInfrastructureClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstallUpdatesOnBoot")]
        public virtual void ResetInstallUpdatesOnBoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceProfileArn")]
        public virtual void ResetInstanceProfileArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastServiceErrorId")]
        public virtual void ResetLastServiceErrorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOs")]
        public virtual void ResetOs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatform")]
        public virtual void ResetPlatform()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateDns")]
        public virtual void ResetPrivateDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIp")]
        public virtual void ResetPrivateIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicDns")]
        public virtual void ResetPublicDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicIp")]
        public virtual void ResetPublicIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegisteredBy")]
        public virtual void ResetRegisteredBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportedAgentVersion")]
        public virtual void ResetReportedAgentVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportedOsFamily")]
        public virtual void ResetReportedOsFamily()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportedOsName")]
        public virtual void ResetReportedOsName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportedOsVersion")]
        public virtual void ResetReportedOsVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootBlockDevice")]
        public virtual void ResetRootBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDeviceType")]
        public virtual void ResetRootDeviceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDeviceVolumeId")]
        public virtual void ResetRootDeviceVolumeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupIds")]
        public virtual void ResetSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshHostDsaKeyFingerprint")]
        public virtual void ResetSshHostDsaKeyFingerprint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshHostRsaKeyFingerprint")]
        public virtual void ResetSshHostRsaKeyFingerprint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshKeyName")]
        public virtual void ResetSshKeyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTenancy")]
        public virtual void ResetTenancy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualizationType")]
        public virtual void ResetVirtualizationType()
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
        = GetStaticProperty<string>(typeof(aws.Opsworks.OpsworksInstance))!;

        [JsiiProperty(name: "ec2InstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opsworks.OpsworksInstanceTimeoutsOutputReference\"}")]
        public virtual aws.Opsworks.OpsworksInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Opsworks.OpsworksInstanceTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AgentVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "amiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AmiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "architectureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArchitectureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoScalingTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createdAtInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreatedAtInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteEbsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteEbsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteEipInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteEipInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDeviceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEbsBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EbsBlockDeviceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimizedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EbsOptimizedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsClusterArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EcsClusterArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ElasticIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDeviceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EphemeralBlockDeviceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InfrastructureClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "installUpdatesOnBootInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InstallUpdatesOnBootInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceProfileArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceProfileArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastServiceErrorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastServiceErrorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "layerIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LayerIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateDnsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateDnsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicDnsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicDnsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registeredByInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegisteredByInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedAgentVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportedAgentVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedOsFamilyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportedOsFamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedOsNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportedOsNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedOsVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportedOsVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootBlockDeviceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceRootBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RootBlockDeviceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootDeviceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceVolumeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootDeviceVolumeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshHostDsaKeyFingerprintInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SshHostDsaKeyFingerprintInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshHostRsaKeyFingerprintInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SshHostRsaKeyFingerprintInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshKeyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SshKeyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stackIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StackIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenancyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenancyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.opsworks.OpsworksInstanceTimeouts\"}", isOptional: true)]
        public virtual aws.Opsworks.IOpsworksInstanceTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Opsworks.IOpsworksInstanceTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualizationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualizationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "amiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AmiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoScalingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteEbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeleteEbs
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteEip", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeleteEip
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEbsBlockDevice\"},\"kind\":\"array\"}}]}}")]
        public virtual object EbsBlockDevice
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EbsOptimized
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ecsClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EcsClusterArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}")]
        public virtual object EphemeralBlockDevice
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "infrastructureClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "installUpdatesOnBoot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object InstallUpdatesOnBoot
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceProfileArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastServiceErrorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastServiceErrorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "layerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LayerIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Os
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDns
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicDns
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "registeredBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegisteredBy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportedAgentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportedAgentVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportedOsFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportedOsFamily
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportedOsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportedOsName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportedOsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportedOsVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceRootBlockDevice\"},\"kind\":\"array\"}}]}}")]
        public virtual object RootBlockDevice
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDeviceVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceVolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshHostDsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshHostDsaKeyFingerprint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshHostRsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshHostRsaKeyFingerprint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshKeyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshKeyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tenancy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualizationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
