using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    /// <summary>AWS Elastic Kubernetes Service.</summary>
    [JsiiInterface(nativeType: typeof(IEksNodeGroupConfig), fullyQualifiedName: "aws.eks.EksNodeGroupConfig")]
    public interface IEksNodeGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#cluster_name EksNodeGroup#cluster_name}.</summary>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#node_group_name EksNodeGroup#node_group_name}.</summary>
        [JsiiProperty(name: "nodeGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string NodeGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#node_role_arn EksNodeGroup#node_role_arn}.</summary>
        [JsiiProperty(name: "nodeRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string NodeRoleArn
        {
            get;
        }

        /// <summary>scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#scaling_config EksNodeGroup#scaling_config}
        /// </remarks>
        [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupScalingConfig\"}")]
        aws.Eks.IEksNodeGroupScalingConfig ScalingConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#subnet_ids EksNodeGroup#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#ami_type EksNodeGroup#ami_type}.</summary>
        [JsiiProperty(name: "amiType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmiType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#disk_size EksNodeGroup#disk_size}.</summary>
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#force_update_version EksNodeGroup#force_update_version}.</summary>
        [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceUpdateVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#instance_types EksNodeGroup#instance_types}.</summary>
        [JsiiProperty(name: "instanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InstanceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#labels EksNodeGroup#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#release_version EksNodeGroup#release_version}.</summary>
        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReleaseVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>remote_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#remote_access EksNodeGroup#remote_access}
        /// </remarks>
        [JsiiProperty(name: "remoteAccess", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupRemoteAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eks.IEksNodeGroupRemoteAccess? RemoteAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#tags EksNodeGroup#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#timeouts EksNodeGroup#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eks.IEksNodeGroupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#version EksNodeGroup#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Elastic Kubernetes Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupConfig), fullyQualifiedName: "aws.eks.EksNodeGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Eks.IEksNodeGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#cluster_name EksNodeGroup#cluster_name}.</summary>
            [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#node_group_name EksNodeGroup#node_group_name}.</summary>
            [JsiiProperty(name: "nodeGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#node_role_arn EksNodeGroup#node_role_arn}.</summary>
            [JsiiProperty(name: "nodeRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>scaling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#scaling_config EksNodeGroup#scaling_config}
            /// </remarks>
            [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupScalingConfig\"}")]
            public aws.Eks.IEksNodeGroupScalingConfig ScalingConfig
            {
                get => GetInstanceProperty<aws.Eks.IEksNodeGroupScalingConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#subnet_ids EksNodeGroup#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#ami_type EksNodeGroup#ami_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "amiType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmiType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#disk_size EksNodeGroup#disk_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#force_update_version EksNodeGroup#force_update_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ForceUpdateVersion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#instance_types EksNodeGroup#instance_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InstanceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#labels EksNodeGroup#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#release_version EksNodeGroup#release_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReleaseVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>remote_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#remote_access EksNodeGroup#remote_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remoteAccess", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupRemoteAccess\"}", isOptional: true)]
            public aws.Eks.IEksNodeGroupRemoteAccess? RemoteAccess
            {
                get => GetInstanceProperty<aws.Eks.IEksNodeGroupRemoteAccess?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#tags EksNodeGroup#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#timeouts EksNodeGroup#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupTimeouts\"}", isOptional: true)]
            public aws.Eks.IEksNodeGroupTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Eks.IEksNodeGroupTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#version EksNodeGroup#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
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
