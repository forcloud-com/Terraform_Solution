using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiInterface(nativeType: typeof(IBatchComputeEnvironmentComputeResources), fullyQualifiedName: "aws.batch.BatchComputeEnvironmentComputeResources")]
    public interface IBatchComputeEnvironmentComputeResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#instance_role BatchComputeEnvironment#instance_role}.</summary>
        [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#instance_type BatchComputeEnvironment#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#max_vcpus BatchComputeEnvironment#max_vcpus}.</summary>
        [JsiiProperty(name: "maxVcpus", typeJson: "{\"primitive\":\"number\"}")]
        double MaxVcpus
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#min_vcpus BatchComputeEnvironment#min_vcpus}.</summary>
        [JsiiProperty(name: "minVcpus", typeJson: "{\"primitive\":\"number\"}")]
        double MinVcpus
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#security_group_ids BatchComputeEnvironment#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#subnets BatchComputeEnvironment#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Subnets
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#type BatchComputeEnvironment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#allocation_strategy BatchComputeEnvironment#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#bid_percentage BatchComputeEnvironment#bid_percentage}.</summary>
        [JsiiProperty(name: "bidPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BidPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#desired_vcpus BatchComputeEnvironment#desired_vcpus}.</summary>
        [JsiiProperty(name: "desiredVcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DesiredVcpus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#ec2_key_pair BatchComputeEnvironment#ec2_key_pair}.</summary>
        [JsiiProperty(name: "ec2KeyPair", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ec2KeyPair
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#image_id BatchComputeEnvironment#image_id}.</summary>
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#launch_template BatchComputeEnvironment#launch_template}
        /// </remarks>
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResourcesLaunchTemplate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Batch.IBatchComputeEnvironmentComputeResourcesLaunchTemplate? LaunchTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#spot_iam_fleet_role BatchComputeEnvironment#spot_iam_fleet_role}.</summary>
        [JsiiProperty(name: "spotIamFleetRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotIamFleetRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#tags BatchComputeEnvironment#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchComputeEnvironmentComputeResources), fullyQualifiedName: "aws.batch.BatchComputeEnvironmentComputeResources")]
        internal sealed class _Proxy : DeputyBase, aws.Batch.IBatchComputeEnvironmentComputeResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#instance_role BatchComputeEnvironment#instance_role}.</summary>
            [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#instance_type BatchComputeEnvironment#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] InstanceType
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#max_vcpus BatchComputeEnvironment#max_vcpus}.</summary>
            [JsiiProperty(name: "maxVcpus", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxVcpus
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#min_vcpus BatchComputeEnvironment#min_vcpus}.</summary>
            [JsiiProperty(name: "minVcpus", typeJson: "{\"primitive\":\"number\"}")]
            public double MinVcpus
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#security_group_ids BatchComputeEnvironment#security_group_ids}.</summary>
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#subnets BatchComputeEnvironment#subnets}.</summary>
            [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Subnets
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#type BatchComputeEnvironment#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#allocation_strategy BatchComputeEnvironment#allocation_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#bid_percentage BatchComputeEnvironment#bid_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bidPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BidPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#desired_vcpus BatchComputeEnvironment#desired_vcpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "desiredVcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DesiredVcpus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#ec2_key_pair BatchComputeEnvironment#ec2_key_pair}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ec2KeyPair", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ec2KeyPair
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#image_id BatchComputeEnvironment#image_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>launch_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#launch_template BatchComputeEnvironment#launch_template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResourcesLaunchTemplate\"}", isOptional: true)]
            public aws.Batch.IBatchComputeEnvironmentComputeResourcesLaunchTemplate? LaunchTemplate
            {
                get => GetInstanceProperty<aws.Batch.IBatchComputeEnvironmentComputeResourcesLaunchTemplate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#spot_iam_fleet_role BatchComputeEnvironment#spot_iam_fleet_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotIamFleetRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotIamFleetRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#tags BatchComputeEnvironment#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
