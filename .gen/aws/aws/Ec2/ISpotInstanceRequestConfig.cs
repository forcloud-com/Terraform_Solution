using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestConfig), fullyQualifiedName: "aws.ec2.SpotInstanceRequestConfig")]
    public interface ISpotInstanceRequestConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ami SpotInstanceRequest#ami}.</summary>
        [JsiiProperty(name: "ami", typeJson: "{\"primitive\":\"string\"}")]
        string Ami
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_type SpotInstanceRequest#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#associate_public_ip_address SpotInstanceRequest#associate_public_ip_address}.</summary>
        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssociatePublicIpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#availability_zone SpotInstanceRequest#availability_zone}.</summary>
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#block_duration_minutes SpotInstanceRequest#block_duration_minutes}.</summary>
        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockDurationMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#cpu_core_count SpotInstanceRequest#cpu_core_count}.</summary>
        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuCoreCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#cpu_threads_per_core SpotInstanceRequest#cpu_threads_per_core}.</summary>
        [JsiiProperty(name: "cpuThreadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuThreadsPerCore
        {
            get
            {
                return null;
            }
        }

        /// <summary>credit_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#credit_specification SpotInstanceRequest#credit_specification}
        /// </remarks>
        [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCreditSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ISpotInstanceRequestCreditSpecification? CreditSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#disable_api_termination SpotInstanceRequest#disable_api_termination}.</summary>
        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableApiTermination
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ebs_block_device SpotInstanceRequest#ebs_block_device}
        /// </remarks>
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotInstanceRequestEbsBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EbsBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ebs_optimized SpotInstanceRequest#ebs_optimized}.</summary>
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EbsOptimized
        {
            get
            {
                return null;
            }
        }

        /// <summary>ephemeral_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ephemeral_block_device SpotInstanceRequest#ephemeral_block_device}
        /// </remarks>
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotInstanceRequestEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EphemeralBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#get_password_data SpotInstanceRequest#get_password_data}.</summary>
        [JsiiProperty(name: "fetchPasswordData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FetchPasswordData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#hibernation SpotInstanceRequest#hibernation}.</summary>
        [JsiiProperty(name: "hibernation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Hibernation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#host_id SpotInstanceRequest#host_id}.</summary>
        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#iam_instance_profile SpotInstanceRequest#iam_instance_profile}.</summary>
        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamInstanceProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_initiated_shutdown_behavior SpotInstanceRequest#instance_initiated_shutdown_behavior}.</summary>
        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceInitiatedShutdownBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_interruption_behaviour SpotInstanceRequest#instance_interruption_behaviour}.</summary>
        [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceInterruptionBehaviour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ipv6_address_count SpotInstanceRequest#ipv6_address_count}.</summary>
        [JsiiProperty(name: "ipv6AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ipv6AddressCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ipv6_addresses SpotInstanceRequest#ipv6_addresses}.</summary>
        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Ipv6Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#key_name SpotInstanceRequest#key_name}.</summary>
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#launch_group SpotInstanceRequest#launch_group}.</summary>
        [JsiiProperty(name: "launchGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>metadata_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#metadata_options SpotInstanceRequest#metadata_options}
        /// </remarks>
        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestMetadataOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ISpotInstanceRequestMetadataOptions? MetadataOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#monitoring SpotInstanceRequest#monitoring}.</summary>
        [JsiiProperty(name: "monitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Monitoring
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_interface block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#network_interface SpotInstanceRequest#network_interface}
        /// </remarks>
        [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotInstanceRequestNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkInterface
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#placement_group SpotInstanceRequest#placement_group}.</summary>
        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#private_ip SpotInstanceRequest#private_ip}.</summary>
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#root_block_device SpotInstanceRequest#root_block_device}
        /// </remarks>
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestRootBlockDevice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ISpotInstanceRequestRootBlockDevice? RootBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#security_groups SpotInstanceRequest#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#source_dest_check SpotInstanceRequest#source_dest_check}.</summary>
        [JsiiProperty(name: "sourceDestCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceDestCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#spot_price SpotInstanceRequest#spot_price}.</summary>
        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#spot_type SpotInstanceRequest#spot_type}.</summary>
        [JsiiProperty(name: "spotType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#subnet_id SpotInstanceRequest#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#tags SpotInstanceRequest#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#tenancy SpotInstanceRequest#tenancy}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#timeouts SpotInstanceRequest#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ISpotInstanceRequestTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#user_data SpotInstanceRequest#user_data}.</summary>
        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#user_data_base64 SpotInstanceRequest#user_data_base64}.</summary>
        [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserDataBase64
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#valid_from SpotInstanceRequest#valid_from}.</summary>
        [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#valid_until SpotInstanceRequest#valid_until}.</summary>
        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidUntil
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#volume_tags SpotInstanceRequest#volume_tags}.</summary>
        [JsiiProperty(name: "volumeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? VolumeTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#vpc_security_group_ids SpotInstanceRequest#vpc_security_group_ids}.</summary>
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#wait_for_fulfillment SpotInstanceRequest#wait_for_fulfillment}.</summary>
        [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WaitForFulfillment
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestConfig), fullyQualifiedName: "aws.ec2.SpotInstanceRequestConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotInstanceRequestConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ami SpotInstanceRequest#ami}.</summary>
            [JsiiProperty(name: "ami", typeJson: "{\"primitive\":\"string\"}")]
            public string Ami
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_type SpotInstanceRequest#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#associate_public_ip_address SpotInstanceRequest#associate_public_ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AssociatePublicIpAddress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#availability_zone SpotInstanceRequest#availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#block_duration_minutes SpotInstanceRequest#block_duration_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockDurationMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#cpu_core_count SpotInstanceRequest#cpu_core_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuCoreCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#cpu_threads_per_core SpotInstanceRequest#cpu_threads_per_core}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuThreadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuThreadsPerCore
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>credit_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#credit_specification SpotInstanceRequest#credit_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCreditSpecification\"}", isOptional: true)]
            public aws.Ec2.ISpotInstanceRequestCreditSpecification? CreditSpecification
            {
                get => GetInstanceProperty<aws.Ec2.ISpotInstanceRequestCreditSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#disable_api_termination SpotInstanceRequest#disable_api_termination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableApiTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableApiTermination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ebs_block_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ebs_block_device SpotInstanceRequest#ebs_block_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotInstanceRequestEbsBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EbsBlockDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ebs_optimized SpotInstanceRequest#ebs_optimized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EbsOptimized
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ephemeral_block_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ephemeral_block_device SpotInstanceRequest#ephemeral_block_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotInstanceRequestEphemeralBlockDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EphemeralBlockDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#get_password_data SpotInstanceRequest#get_password_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fetchPasswordData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? FetchPasswordData
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#hibernation SpotInstanceRequest#hibernation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hibernation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Hibernation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#host_id SpotInstanceRequest#host_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#iam_instance_profile SpotInstanceRequest#iam_instance_profile}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamInstanceProfile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_initiated_shutdown_behavior SpotInstanceRequest#instance_initiated_shutdown_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceInitiatedShutdownBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_interruption_behaviour SpotInstanceRequest#instance_interruption_behaviour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceInterruptionBehaviour
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ipv6_address_count SpotInstanceRequest#ipv6_address_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ipv6AddressCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ipv6_addresses SpotInstanceRequest#ipv6_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Ipv6Addresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#key_name SpotInstanceRequest#key_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#launch_group SpotInstanceRequest#launch_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "launchGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metadata_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#metadata_options SpotInstanceRequest#metadata_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestMetadataOptions\"}", isOptional: true)]
            public aws.Ec2.ISpotInstanceRequestMetadataOptions? MetadataOptions
            {
                get => GetInstanceProperty<aws.Ec2.ISpotInstanceRequestMetadataOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#monitoring SpotInstanceRequest#monitoring}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Monitoring
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_interface block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#network_interface SpotInstanceRequest#network_interface}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotInstanceRequestNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkInterface
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#placement_group SpotInstanceRequest#placement_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#private_ip SpotInstanceRequest#private_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>root_block_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#root_block_device SpotInstanceRequest#root_block_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestRootBlockDevice\"}", isOptional: true)]
            public aws.Ec2.ISpotInstanceRequestRootBlockDevice? RootBlockDevice
            {
                get => GetInstanceProperty<aws.Ec2.ISpotInstanceRequestRootBlockDevice?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#security_groups SpotInstanceRequest#security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#source_dest_check SpotInstanceRequest#source_dest_check}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDestCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SourceDestCheck
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#spot_price SpotInstanceRequest#spot_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#spot_type SpotInstanceRequest#spot_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#subnet_id SpotInstanceRequest#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#tags SpotInstanceRequest#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#tenancy SpotInstanceRequest#tenancy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tenancy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#timeouts SpotInstanceRequest#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestTimeouts\"}", isOptional: true)]
            public aws.Ec2.ISpotInstanceRequestTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Ec2.ISpotInstanceRequestTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#user_data SpotInstanceRequest#user_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#user_data_base64 SpotInstanceRequest#user_data_base64}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserDataBase64
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#valid_from SpotInstanceRequest#valid_from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidFrom
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#valid_until SpotInstanceRequest#valid_until}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidUntil
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#volume_tags SpotInstanceRequest#volume_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? VolumeTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#vpc_security_group_ids SpotInstanceRequest#vpc_security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#wait_for_fulfillment SpotInstanceRequest#wait_for_fulfillment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? WaitForFulfillment
            {
                get => GetInstanceProperty<object?>();
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
