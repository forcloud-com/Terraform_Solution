using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(ILaunchTemplateConfig), fullyQualifiedName: "aws.ec2.LaunchTemplateConfig")]
    public interface ILaunchTemplateConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>block_device_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#block_device_mappings LaunchTemplate#block_device_mappings}
        /// </remarks>
        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BlockDeviceMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>capacity_reservation_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#capacity_reservation_specification LaunchTemplate#capacity_reservation_specification}
        /// </remarks>
        [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateCapacityReservationSpecification? CapacityReservationSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>cpu_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#cpu_options LaunchTemplate#cpu_options}
        /// </remarks>
        [JsiiProperty(name: "cpuOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCpuOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateCpuOptions? CpuOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>credit_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#credit_specification LaunchTemplate#credit_specification}
        /// </remarks>
        [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCreditSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateCreditSpecification? CreditSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#default_version LaunchTemplate#default_version}.</summary>
        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#description LaunchTemplate#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#disable_api_termination LaunchTemplate#disable_api_termination}.</summary>
        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableApiTermination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ebs_optimized LaunchTemplate#ebs_optimized}.</summary>
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EbsOptimized
        {
            get
            {
                return null;
            }
        }

        /// <summary>elastic_gpu_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#elastic_gpu_specifications LaunchTemplate#elastic_gpu_specifications}
        /// </remarks>
        [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ElasticGpuSpecifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>elastic_inference_accelerator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#elastic_inference_accelerator LaunchTemplate#elastic_inference_accelerator}
        /// </remarks>
        [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateElasticInferenceAccelerator\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateElasticInferenceAccelerator? ElasticInferenceAccelerator
        {
            get
            {
                return null;
            }
        }

        /// <summary>hibernation_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#hibernation_options LaunchTemplate#hibernation_options}
        /// </remarks>
        [JsiiProperty(name: "hibernationOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateHibernationOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateHibernationOptions? HibernationOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>iam_instance_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#iam_instance_profile LaunchTemplate#iam_instance_profile}
        /// </remarks>
        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateIamInstanceProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateIamInstanceProfile? IamInstanceProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#image_id LaunchTemplate#image_id}.</summary>
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_initiated_shutdown_behavior LaunchTemplate#instance_initiated_shutdown_behavior}.</summary>
        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceInitiatedShutdownBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_market_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_market_options LaunchTemplate#instance_market_options}
        /// </remarks>
        [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateInstanceMarketOptions? InstanceMarketOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_type LaunchTemplate#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#kernel_id LaunchTemplate#kernel_id}.</summary>
        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KernelId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#key_name LaunchTemplate#key_name}.</summary>
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>license_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#license_specification LaunchTemplate#license_specification}
        /// </remarks>
        [JsiiProperty(name: "licenseSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LicenseSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>metadata_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#metadata_options LaunchTemplate#metadata_options}
        /// </remarks>
        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMetadataOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateMetadataOptions? MetadataOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitoring block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#monitoring LaunchTemplate#monitoring}
        /// </remarks>
        [JsiiProperty(name: "monitoring", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMonitoring\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateMonitoring? Monitoring
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#name LaunchTemplate#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#name_prefix LaunchTemplate#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_interfaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#network_interfaces LaunchTemplate#network_interfaces}
        /// </remarks>
        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkInterfaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>placement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#placement LaunchTemplate#placement}
        /// </remarks>
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplatePlacement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplatePlacement? Placement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ram_disk_id LaunchTemplate#ram_disk_id}.</summary>
        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RamDiskId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#security_group_names LaunchTemplate#security_group_names}.</summary>
        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tags LaunchTemplate#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tag_specifications LaunchTemplate#tag_specifications}
        /// </remarks>
        [JsiiProperty(name: "tagSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TagSpecifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#update_default_version LaunchTemplate#update_default_version}.</summary>
        [JsiiProperty(name: "updateDefaultVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UpdateDefaultVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#user_data LaunchTemplate#user_data}.</summary>
        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#vpc_security_group_ids LaunchTemplate#vpc_security_group_ids}.</summary>
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateConfig), fullyQualifiedName: "aws.ec2.LaunchTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ILaunchTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>block_device_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#block_device_mappings LaunchTemplate#block_device_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BlockDeviceMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>capacity_reservation_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#capacity_reservation_specification LaunchTemplate#capacity_reservation_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecification\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateCapacityReservationSpecification? CapacityReservationSpecification
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateCapacityReservationSpecification?>();
            }

            /// <summary>cpu_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#cpu_options LaunchTemplate#cpu_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpuOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCpuOptions\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateCpuOptions? CpuOptions
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateCpuOptions?>();
            }

            /// <summary>credit_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#credit_specification LaunchTemplate#credit_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCreditSpecification\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateCreditSpecification? CreditSpecification
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateCreditSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#default_version LaunchTemplate#default_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#description LaunchTemplate#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#disable_api_termination LaunchTemplate#disable_api_termination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableApiTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableApiTermination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ebs_optimized LaunchTemplate#ebs_optimized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EbsOptimized
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>elastic_gpu_specifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#elastic_gpu_specifications LaunchTemplate#elastic_gpu_specifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ElasticGpuSpecifications
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>elastic_inference_accelerator block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#elastic_inference_accelerator LaunchTemplate#elastic_inference_accelerator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateElasticInferenceAccelerator\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateElasticInferenceAccelerator? ElasticInferenceAccelerator
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateElasticInferenceAccelerator?>();
            }

            /// <summary>hibernation_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#hibernation_options LaunchTemplate#hibernation_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hibernationOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateHibernationOptions\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateHibernationOptions? HibernationOptions
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateHibernationOptions?>();
            }

            /// <summary>iam_instance_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#iam_instance_profile LaunchTemplate#iam_instance_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateIamInstanceProfile\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateIamInstanceProfile? IamInstanceProfile
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateIamInstanceProfile?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#image_id LaunchTemplate#image_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_initiated_shutdown_behavior LaunchTemplate#instance_initiated_shutdown_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceInitiatedShutdownBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>instance_market_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_market_options LaunchTemplate#instance_market_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptions\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateInstanceMarketOptions? InstanceMarketOptions
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateInstanceMarketOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_type LaunchTemplate#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#kernel_id LaunchTemplate#kernel_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KernelId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#key_name LaunchTemplate#key_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>license_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#license_specification LaunchTemplate#license_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "licenseSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LicenseSpecification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>metadata_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#metadata_options LaunchTemplate#metadata_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMetadataOptions\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateMetadataOptions? MetadataOptions
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateMetadataOptions?>();
            }

            /// <summary>monitoring block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#monitoring LaunchTemplate#monitoring}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitoring", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMonitoring\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateMonitoring? Monitoring
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateMonitoring?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#name LaunchTemplate#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#name_prefix LaunchTemplate#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_interfaces block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#network_interfaces LaunchTemplate#network_interfaces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkInterfaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>placement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#placement LaunchTemplate#placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplatePlacement\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplatePlacement? Placement
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplatePlacement?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ram_disk_id LaunchTemplate#ram_disk_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RamDiskId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#security_group_names LaunchTemplate#security_group_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tags LaunchTemplate#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>tag_specifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tag_specifications LaunchTemplate#tag_specifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TagSpecifications
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#update_default_version LaunchTemplate#update_default_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateDefaultVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UpdateDefaultVersion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#user_data LaunchTemplate#user_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#vpc_security_group_ids LaunchTemplate#vpc_security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
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
