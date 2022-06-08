using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateConfig")]
    public class LaunchTemplateConfig : aws.Ec2.ILaunchTemplateConfig
    {
        /// <summary>block_device_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#block_device_mappings LaunchTemplate#block_device_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BlockDeviceMappings
        {
            get;
            set;
        }

        /// <summary>capacity_reservation_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#capacity_reservation_specification LaunchTemplate#capacity_reservation_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecification\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateCapacityReservationSpecification? CapacityReservationSpecification
        {
            get;
            set;
        }

        /// <summary>cpu_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#cpu_options LaunchTemplate#cpu_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpuOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCpuOptions\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateCpuOptions? CpuOptions
        {
            get;
            set;
        }

        /// <summary>credit_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#credit_specification LaunchTemplate#credit_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCreditSpecification\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateCreditSpecification? CreditSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#default_version LaunchTemplate#default_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DefaultVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#description LaunchTemplate#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#disable_api_termination LaunchTemplate#disable_api_termination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DisableApiTermination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ebs_optimized LaunchTemplate#ebs_optimized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EbsOptimized
        {
            get;
            set;
        }

        /// <summary>elastic_gpu_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#elastic_gpu_specifications LaunchTemplate#elastic_gpu_specifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ElasticGpuSpecifications
        {
            get;
            set;
        }

        /// <summary>elastic_inference_accelerator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#elastic_inference_accelerator LaunchTemplate#elastic_inference_accelerator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateElasticInferenceAccelerator\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateElasticInferenceAccelerator? ElasticInferenceAccelerator
        {
            get;
            set;
        }

        /// <summary>hibernation_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#hibernation_options LaunchTemplate#hibernation_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hibernationOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateHibernationOptions\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateHibernationOptions? HibernationOptions
        {
            get;
            set;
        }

        /// <summary>iam_instance_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#iam_instance_profile LaunchTemplate#iam_instance_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateIamInstanceProfile\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateIamInstanceProfile? IamInstanceProfile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#image_id LaunchTemplate#image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_initiated_shutdown_behavior LaunchTemplate#instance_initiated_shutdown_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceInitiatedShutdownBehavior
        {
            get;
            set;
        }

        /// <summary>instance_market_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_market_options LaunchTemplate#instance_market_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptions\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateInstanceMarketOptions? InstanceMarketOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_type LaunchTemplate#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#kernel_id LaunchTemplate#kernel_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KernelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#key_name LaunchTemplate#key_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyName
        {
            get;
            set;
        }

        /// <summary>license_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#license_specification LaunchTemplate#license_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "licenseSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LicenseSpecification
        {
            get;
            set;
        }

        /// <summary>metadata_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#metadata_options LaunchTemplate#metadata_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMetadataOptions\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateMetadataOptions? MetadataOptions
        {
            get;
            set;
        }

        /// <summary>monitoring block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#monitoring LaunchTemplate#monitoring}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitoring", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMonitoring\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateMonitoring? Monitoring
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#name LaunchTemplate#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#name_prefix LaunchTemplate#name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamePrefix
        {
            get;
            set;
        }

        /// <summary>network_interfaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#network_interfaces LaunchTemplate#network_interfaces}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkInterfaces
        {
            get;
            set;
        }

        /// <summary>placement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#placement LaunchTemplate#placement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplatePlacement\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplatePlacement? Placement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ram_disk_id LaunchTemplate#ram_disk_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RamDiskId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#security_group_names LaunchTemplate#security_group_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tags LaunchTemplate#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>tag_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tag_specifications LaunchTemplate#tag_specifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TagSpecifications
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#update_default_version LaunchTemplate#update_default_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateDefaultVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UpdateDefaultVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#user_data LaunchTemplate#user_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserData
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#vpc_security_group_ids LaunchTemplate#vpc_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpcSecurityGroupIds
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
