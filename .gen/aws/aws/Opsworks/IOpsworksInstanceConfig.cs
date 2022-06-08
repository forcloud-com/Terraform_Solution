using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    /// <summary>AWS OpsWorks.</summary>
    [JsiiInterface(nativeType: typeof(IOpsworksInstanceConfig), fullyQualifiedName: "aws.opsworks.OpsworksInstanceConfig")]
    public interface IOpsworksInstanceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#layer_ids OpsworksInstance#layer_ids}.</summary>
        [JsiiProperty(name: "layerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] LayerIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#stack_id OpsworksInstance#stack_id}.</summary>
        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        string StackId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#agent_version OpsworksInstance#agent_version}.</summary>
        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ami_id OpsworksInstance#ami_id}.</summary>
        [JsiiProperty(name: "amiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmiId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#architecture OpsworksInstance#architecture}.</summary>
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Architecture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#auto_scaling_type OpsworksInstance#auto_scaling_type}.</summary>
        [JsiiProperty(name: "autoScalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoScalingType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#availability_zone OpsworksInstance#availability_zone}.</summary>
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#created_at OpsworksInstance#created_at}.</summary>
        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#delete_ebs OpsworksInstance#delete_ebs}.</summary>
        [JsiiProperty(name: "deleteEbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteEbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#delete_eip OpsworksInstance#delete_eip}.</summary>
        [JsiiProperty(name: "deleteEip", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteEip
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ebs_block_device OpsworksInstance#ebs_block_device}
        /// </remarks>
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEbsBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EbsBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ebs_optimized OpsworksInstance#ebs_optimized}.</summary>
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EbsOptimized
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ecs_cluster_arn OpsworksInstance#ecs_cluster_arn}.</summary>
        [JsiiProperty(name: "ecsClusterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EcsClusterArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#elastic_ip OpsworksInstance#elastic_ip}.</summary>
        [JsiiProperty(name: "elasticIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElasticIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>ephemeral_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ephemeral_block_device OpsworksInstance#ephemeral_block_device}
        /// </remarks>
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EphemeralBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#hostname OpsworksInstance#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#infrastructure_class OpsworksInstance#infrastructure_class}.</summary>
        [JsiiProperty(name: "infrastructureClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InfrastructureClass
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#install_updates_on_boot OpsworksInstance#install_updates_on_boot}.</summary>
        [JsiiProperty(name: "installUpdatesOnBoot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InstallUpdatesOnBoot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#instance_profile_arn OpsworksInstance#instance_profile_arn}.</summary>
        [JsiiProperty(name: "instanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceProfileArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#instance_type OpsworksInstance#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#last_service_error_id OpsworksInstance#last_service_error_id}.</summary>
        [JsiiProperty(name: "lastServiceErrorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastServiceErrorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#os OpsworksInstance#os}.</summary>
        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Os
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#platform OpsworksInstance#platform}.</summary>
        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Platform
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#private_dns OpsworksInstance#private_dns}.</summary>
        [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateDns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#private_ip OpsworksInstance#private_ip}.</summary>
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#public_dns OpsworksInstance#public_dns}.</summary>
        [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicDns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#public_ip OpsworksInstance#public_ip}.</summary>
        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#registered_by OpsworksInstance#registered_by}.</summary>
        [JsiiProperty(name: "registeredBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegisteredBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_agent_version OpsworksInstance#reported_agent_version}.</summary>
        [JsiiProperty(name: "reportedAgentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReportedAgentVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_os_family OpsworksInstance#reported_os_family}.</summary>
        [JsiiProperty(name: "reportedOsFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReportedOsFamily
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_os_name OpsworksInstance#reported_os_name}.</summary>
        [JsiiProperty(name: "reportedOsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReportedOsName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_os_version OpsworksInstance#reported_os_version}.</summary>
        [JsiiProperty(name: "reportedOsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReportedOsVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#root_block_device OpsworksInstance#root_block_device}
        /// </remarks>
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceRootBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RootBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#root_device_type OpsworksInstance#root_device_type}.</summary>
        [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootDeviceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#root_device_volume_id OpsworksInstance#root_device_volume_id}.</summary>
        [JsiiProperty(name: "rootDeviceVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootDeviceVolumeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#security_group_ids OpsworksInstance#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ssh_host_dsa_key_fingerprint OpsworksInstance#ssh_host_dsa_key_fingerprint}.</summary>
        [JsiiProperty(name: "sshHostDsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SshHostDsaKeyFingerprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ssh_host_rsa_key_fingerprint OpsworksInstance#ssh_host_rsa_key_fingerprint}.</summary>
        [JsiiProperty(name: "sshHostRsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SshHostRsaKeyFingerprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ssh_key_name OpsworksInstance#ssh_key_name}.</summary>
        [JsiiProperty(name: "sshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SshKeyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#state OpsworksInstance#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#status OpsworksInstance#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#subnet_id OpsworksInstance#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#tenancy OpsworksInstance#tenancy}.</summary>
        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tenancy
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#timeouts OpsworksInstance#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opsworks.OpsworksInstanceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Opsworks.IOpsworksInstanceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#virtualization_type OpsworksInstance#virtualization_type}.</summary>
        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualizationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS OpsWorks.</summary>
        [JsiiTypeProxy(nativeType: typeof(IOpsworksInstanceConfig), fullyQualifiedName: "aws.opsworks.OpsworksInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Opsworks.IOpsworksInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#layer_ids OpsworksInstance#layer_ids}.</summary>
            [JsiiProperty(name: "layerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] LayerIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#stack_id OpsworksInstance#stack_id}.</summary>
            [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
            public string StackId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#agent_version OpsworksInstance#agent_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ami_id OpsworksInstance#ami_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "amiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmiId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#architecture OpsworksInstance#architecture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Architecture
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#auto_scaling_type OpsworksInstance#auto_scaling_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoScalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoScalingType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#availability_zone OpsworksInstance#availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#created_at OpsworksInstance#created_at}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedAt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#delete_ebs OpsworksInstance#delete_ebs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteEbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteEbs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#delete_eip OpsworksInstance#delete_eip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteEip", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteEip
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ebs_block_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ebs_block_device OpsworksInstance#ebs_block_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEbsBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EbsBlockDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ebs_optimized OpsworksInstance#ebs_optimized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EbsOptimized
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ecs_cluster_arn OpsworksInstance#ecs_cluster_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ecsClusterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EcsClusterArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#elastic_ip OpsworksInstance#elastic_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElasticIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ephemeral_block_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ephemeral_block_device OpsworksInstance#ephemeral_block_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EphemeralBlockDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#hostname OpsworksInstance#hostname}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hostname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#infrastructure_class OpsworksInstance#infrastructure_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "infrastructureClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InfrastructureClass
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#install_updates_on_boot OpsworksInstance#install_updates_on_boot}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "installUpdatesOnBoot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InstallUpdatesOnBoot
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#instance_profile_arn OpsworksInstance#instance_profile_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceProfileArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#instance_type OpsworksInstance#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#last_service_error_id OpsworksInstance#last_service_error_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastServiceErrorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastServiceErrorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#os OpsworksInstance#os}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Os
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#platform OpsworksInstance#platform}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Platform
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#private_dns OpsworksInstance#private_dns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateDns
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#private_ip OpsworksInstance#private_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#public_dns OpsworksInstance#public_dns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicDns
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#public_ip OpsworksInstance#public_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#registered_by OpsworksInstance#registered_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "registeredBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegisteredBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_agent_version OpsworksInstance#reported_agent_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reportedAgentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReportedAgentVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_os_family OpsworksInstance#reported_os_family}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reportedOsFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReportedOsFamily
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_os_name OpsworksInstance#reported_os_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reportedOsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReportedOsName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_os_version OpsworksInstance#reported_os_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reportedOsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReportedOsVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>root_block_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#root_block_device OpsworksInstance#root_block_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceRootBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RootBlockDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#root_device_type OpsworksInstance#root_device_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootDeviceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#root_device_volume_id OpsworksInstance#root_device_volume_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootDeviceVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootDeviceVolumeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#security_group_ids OpsworksInstance#security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ssh_host_dsa_key_fingerprint OpsworksInstance#ssh_host_dsa_key_fingerprint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sshHostDsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SshHostDsaKeyFingerprint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ssh_host_rsa_key_fingerprint OpsworksInstance#ssh_host_rsa_key_fingerprint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sshHostRsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SshHostRsaKeyFingerprint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ssh_key_name OpsworksInstance#ssh_key_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SshKeyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#state OpsworksInstance#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#status OpsworksInstance#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#subnet_id OpsworksInstance#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#tenancy OpsworksInstance#tenancy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tenancy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#timeouts OpsworksInstance#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opsworks.OpsworksInstanceTimeouts\"}", isOptional: true)]
            public aws.Opsworks.IOpsworksInstanceTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Opsworks.IOpsworksInstanceTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#virtualization_type OpsworksInstance#virtualization_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualizationType
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
