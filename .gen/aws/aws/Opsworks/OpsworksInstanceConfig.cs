using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    /// <summary>AWS OpsWorks.</summary>
    [JsiiByValue(fqn: "aws.opsworks.OpsworksInstanceConfig")]
    public class OpsworksInstanceConfig : aws.Opsworks.IOpsworksInstanceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#layer_ids OpsworksInstance#layer_ids}.</summary>
        [JsiiProperty(name: "layerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] LayerIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#stack_id OpsworksInstance#stack_id}.</summary>
        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public string StackId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#agent_version OpsworksInstance#agent_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AgentVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ami_id OpsworksInstance#ami_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#architecture OpsworksInstance#architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Architecture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#auto_scaling_type OpsworksInstance#auto_scaling_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoScalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoScalingType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#availability_zone OpsworksInstance#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#created_at OpsworksInstance#created_at}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedAt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#delete_ebs OpsworksInstance#delete_ebs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteEbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteEbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#delete_eip OpsworksInstance#delete_eip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteEip", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteEip
        {
            get;
            set;
        }

        /// <summary>ebs_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ebs_block_device OpsworksInstance#ebs_block_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEbsBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EbsBlockDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ebs_optimized OpsworksInstance#ebs_optimized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EbsOptimized
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ecs_cluster_arn OpsworksInstance#ecs_cluster_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ecsClusterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EcsClusterArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#elastic_ip OpsworksInstance#elastic_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElasticIp
        {
            get;
            set;
        }

        /// <summary>ephemeral_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ephemeral_block_device OpsworksInstance#ephemeral_block_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EphemeralBlockDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#hostname OpsworksInstance#hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#infrastructure_class OpsworksInstance#infrastructure_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "infrastructureClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InfrastructureClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#install_updates_on_boot OpsworksInstance#install_updates_on_boot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "installUpdatesOnBoot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InstallUpdatesOnBoot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#instance_profile_arn OpsworksInstance#instance_profile_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceProfileArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#instance_type OpsworksInstance#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#last_service_error_id OpsworksInstance#last_service_error_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastServiceErrorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastServiceErrorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#os OpsworksInstance#os}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Os
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#platform OpsworksInstance#platform}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Platform
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#private_dns OpsworksInstance#private_dns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateDns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#private_ip OpsworksInstance#private_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#public_dns OpsworksInstance#public_dns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicDns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#public_ip OpsworksInstance#public_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#registered_by OpsworksInstance#registered_by}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registeredBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegisteredBy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_agent_version OpsworksInstance#reported_agent_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reportedAgentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReportedAgentVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_os_family OpsworksInstance#reported_os_family}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reportedOsFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReportedOsFamily
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_os_name OpsworksInstance#reported_os_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reportedOsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReportedOsName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#reported_os_version OpsworksInstance#reported_os_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reportedOsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReportedOsVersion
        {
            get;
            set;
        }

        /// <summary>root_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#root_block_device OpsworksInstance#root_block_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksInstanceRootBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RootBlockDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#root_device_type OpsworksInstance#root_device_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootDeviceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#root_device_volume_id OpsworksInstance#root_device_volume_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootDeviceVolumeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#security_group_ids OpsworksInstance#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ssh_host_dsa_key_fingerprint OpsworksInstance#ssh_host_dsa_key_fingerprint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshHostDsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SshHostDsaKeyFingerprint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ssh_host_rsa_key_fingerprint OpsworksInstance#ssh_host_rsa_key_fingerprint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshHostRsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SshHostRsaKeyFingerprint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#ssh_key_name OpsworksInstance#ssh_key_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SshKeyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#state OpsworksInstance#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#status OpsworksInstance#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#subnet_id OpsworksInstance#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#tenancy OpsworksInstance#tenancy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tenancy
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#timeouts OpsworksInstance#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opsworks.OpsworksInstanceTimeouts\"}", isOptional: true)]
        public aws.Opsworks.IOpsworksInstanceTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_instance#virtualization_type OpsworksInstance#virtualization_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualizationType
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
