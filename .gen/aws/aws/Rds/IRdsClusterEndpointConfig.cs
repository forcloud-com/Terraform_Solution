using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    /// <summary>AWS Relational Database Service.</summary>
    [JsiiInterface(nativeType: typeof(IRdsClusterEndpointConfig), fullyQualifiedName: "aws.rds.RdsClusterEndpointConfig")]
    public interface IRdsClusterEndpointConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#cluster_endpoint_identifier RdsClusterEndpoint#cluster_endpoint_identifier}.</summary>
        [JsiiProperty(name: "clusterEndpointIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterEndpointIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#cluster_identifier RdsClusterEndpoint#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#custom_endpoint_type RdsClusterEndpoint#custom_endpoint_type}.</summary>
        [JsiiProperty(name: "customEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        string CustomEndpointType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#excluded_members RdsClusterEndpoint#excluded_members}.</summary>
        [JsiiProperty(name: "excludedMembers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedMembers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#static_members RdsClusterEndpoint#static_members}.</summary>
        [JsiiProperty(name: "staticMembers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? StaticMembers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#tags RdsClusterEndpoint#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Relational Database Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IRdsClusterEndpointConfig), fullyQualifiedName: "aws.rds.RdsClusterEndpointConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Rds.IRdsClusterEndpointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#cluster_endpoint_identifier RdsClusterEndpoint#cluster_endpoint_identifier}.</summary>
            [JsiiProperty(name: "clusterEndpointIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterEndpointIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#cluster_identifier RdsClusterEndpoint#cluster_identifier}.</summary>
            [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#custom_endpoint_type RdsClusterEndpoint#custom_endpoint_type}.</summary>
            [JsiiProperty(name: "customEndpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomEndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#excluded_members RdsClusterEndpoint#excluded_members}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedMembers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedMembers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#static_members RdsClusterEndpoint#static_members}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "staticMembers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? StaticMembers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_endpoint#tags RdsClusterEndpoint#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
