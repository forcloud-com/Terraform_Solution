using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    /// <summary>AWS OpsWorks.</summary>
    [JsiiByValue(fqn: "aws.opsworks.OpsworksStackConfig")]
    public class OpsworksStackConfig : aws.Opsworks.IOpsworksStackConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_instance_profile_arn OpsworksStack#default_instance_profile_arn}.</summary>
        [JsiiProperty(name: "defaultInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultInstanceProfileArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#name OpsworksStack#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#region OpsworksStack#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#service_role_arn OpsworksStack#service_role_arn}.</summary>
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#agent_version OpsworksStack#agent_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AgentVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#berkshelf_version OpsworksStack#berkshelf_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "berkshelfVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BerkshelfVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#color OpsworksStack#color}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "color", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Color
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#configuration_manager_name OpsworksStack#configuration_manager_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurationManagerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigurationManagerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#configuration_manager_version OpsworksStack#configuration_manager_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurationManagerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigurationManagerVersion
        {
            get;
            set;
        }

        /// <summary>custom_cookbooks_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#custom_cookbooks_source OpsworksStack#custom_cookbooks_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customCookbooksSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksStackCustomCookbooksSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomCookbooksSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#custom_json OpsworksStack#custom_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomJson
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_availability_zone OpsworksStack#default_availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_os OpsworksStack#default_os}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultOs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultOs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_root_device_type OpsworksStack#default_root_device_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultRootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultRootDeviceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_ssh_key_name OpsworksStack#default_ssh_key_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultSshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultSshKeyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_subnet_id OpsworksStack#default_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#hostname_theme OpsworksStack#hostname_theme}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostnameTheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostnameTheme
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#manage_berkshelf OpsworksStack#manage_berkshelf}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manageBerkshelf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ManageBerkshelf
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#tags OpsworksStack#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#use_custom_cookbooks OpsworksStack#use_custom_cookbooks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useCustomCookbooks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseCustomCookbooks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#use_opsworks_security_groups OpsworksStack#use_opsworks_security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useOpsworksSecurityGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseOpsworksSecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#vpc_id OpsworksStack#vpc_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcId
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
