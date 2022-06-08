using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    #pragma warning disable CS8618

    /// <summary>AWS Elastic Kubernetes Service.</summary>
    [JsiiByValue(fqn: "aws.eks.EksNodeGroupConfig")]
    public class EksNodeGroupConfig : aws.Eks.IEksNodeGroupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#cluster_name EksNodeGroup#cluster_name}.</summary>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#node_group_name EksNodeGroup#node_group_name}.</summary>
        [JsiiProperty(name: "nodeGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#node_role_arn EksNodeGroup#node_role_arn}.</summary>
        [JsiiProperty(name: "nodeRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeRoleArn
        {
            get;
            set;
        }

        /// <summary>scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#scaling_config EksNodeGroup#scaling_config}
        /// </remarks>
        [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupScalingConfig\"}")]
        public aws.Eks.IEksNodeGroupScalingConfig ScalingConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#subnet_ids EksNodeGroup#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#ami_type EksNodeGroup#ami_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amiType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmiType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#disk_size EksNodeGroup#disk_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiskSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#force_update_version EksNodeGroup#force_update_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForceUpdateVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#instance_types EksNodeGroup#instance_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InstanceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#labels EksNodeGroup#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#release_version EksNodeGroup#release_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReleaseVersion
        {
            get;
            set;
        }

        /// <summary>remote_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#remote_access EksNodeGroup#remote_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteAccess", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupRemoteAccess\"}", isOptional: true)]
        public aws.Eks.IEksNodeGroupRemoteAccess? RemoteAccess
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#tags EksNodeGroup#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#timeouts EksNodeGroup#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupTimeouts\"}", isOptional: true)]
        public aws.Eks.IEksNodeGroupTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#version EksNodeGroup#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
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
