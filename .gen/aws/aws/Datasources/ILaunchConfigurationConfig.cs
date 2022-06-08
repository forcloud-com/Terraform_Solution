using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    /// <summary>AWS Data Sources.</summary>
    [JsiiInterface(nativeType: typeof(ILaunchConfigurationConfig), fullyQualifiedName: "aws.datasources.LaunchConfigurationConfig")]
    public interface ILaunchConfigurationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#image_id LaunchConfiguration#image_id}.</summary>
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        string ImageId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#instance_type LaunchConfiguration#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#associate_public_ip_address LaunchConfiguration#associate_public_ip_address}.</summary>
        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssociatePublicIpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#ebs_block_device LaunchConfiguration#ebs_block_device}
        /// </remarks>
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datasources.LaunchConfigurationEbsBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EbsBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#ebs_optimized LaunchConfiguration#ebs_optimized}.</summary>
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EbsOptimized
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#enable_monitoring LaunchConfiguration#enable_monitoring}.</summary>
        [JsiiProperty(name: "enableMonitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableMonitoring
        {
            get
            {
                return null;
            }
        }

        /// <summary>ephemeral_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#ephemeral_block_device LaunchConfiguration#ephemeral_block_device}
        /// </remarks>
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datasources.LaunchConfigurationEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EphemeralBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#iam_instance_profile LaunchConfiguration#iam_instance_profile}.</summary>
        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamInstanceProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#key_name LaunchConfiguration#key_name}.</summary>
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#name LaunchConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#name_prefix LaunchConfiguration#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#placement_tenancy LaunchConfiguration#placement_tenancy}.</summary>
        [JsiiProperty(name: "placementTenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementTenancy
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#root_block_device LaunchConfiguration#root_block_device}
        /// </remarks>
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"fqn\":\"aws.datasources.LaunchConfigurationRootBlockDevice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Datasources.ILaunchConfigurationRootBlockDevice? RootBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#security_groups LaunchConfiguration#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#spot_price LaunchConfiguration#spot_price}.</summary>
        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#user_data LaunchConfiguration#user_data}.</summary>
        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#user_data_base64 LaunchConfiguration#user_data_base64}.</summary>
        [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserDataBase64
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#vpc_classic_link_id LaunchConfiguration#vpc_classic_link_id}.</summary>
        [JsiiProperty(name: "vpcClassicLinkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcClassicLinkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#vpc_classic_link_security_groups LaunchConfiguration#vpc_classic_link_security_groups}.</summary>
        [JsiiProperty(name: "vpcClassicLinkSecurityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcClassicLinkSecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Data Sources.</summary>
        [JsiiTypeProxy(nativeType: typeof(ILaunchConfigurationConfig), fullyQualifiedName: "aws.datasources.LaunchConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Datasources.ILaunchConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#image_id LaunchConfiguration#image_id}.</summary>
            [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#instance_type LaunchConfiguration#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#associate_public_ip_address LaunchConfiguration#associate_public_ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AssociatePublicIpAddress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ebs_block_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#ebs_block_device LaunchConfiguration#ebs_block_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datasources.LaunchConfigurationEbsBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EbsBlockDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#ebs_optimized LaunchConfiguration#ebs_optimized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EbsOptimized
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#enable_monitoring LaunchConfiguration#enable_monitoring}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableMonitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableMonitoring
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ephemeral_block_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#ephemeral_block_device LaunchConfiguration#ephemeral_block_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datasources.LaunchConfigurationEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EphemeralBlockDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#iam_instance_profile LaunchConfiguration#iam_instance_profile}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamInstanceProfile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#key_name LaunchConfiguration#key_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#name LaunchConfiguration#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#name_prefix LaunchConfiguration#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#placement_tenancy LaunchConfiguration#placement_tenancy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementTenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementTenancy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>root_block_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#root_block_device LaunchConfiguration#root_block_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"fqn\":\"aws.datasources.LaunchConfigurationRootBlockDevice\"}", isOptional: true)]
            public aws.Datasources.ILaunchConfigurationRootBlockDevice? RootBlockDevice
            {
                get => GetInstanceProperty<aws.Datasources.ILaunchConfigurationRootBlockDevice?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#security_groups LaunchConfiguration#security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#spot_price LaunchConfiguration#spot_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#user_data LaunchConfiguration#user_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#user_data_base64 LaunchConfiguration#user_data_base64}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserDataBase64
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#vpc_classic_link_id LaunchConfiguration#vpc_classic_link_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcClassicLinkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcClassicLinkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_configuration#vpc_classic_link_security_groups LaunchConfiguration#vpc_classic_link_security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcClassicLinkSecurityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcClassicLinkSecurityGroups
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
