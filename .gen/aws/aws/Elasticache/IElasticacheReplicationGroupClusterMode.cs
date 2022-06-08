using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticache
{
    [JsiiInterface(nativeType: typeof(IElasticacheReplicationGroupClusterMode), fullyQualifiedName: "aws.elasticache.ElasticacheReplicationGroupClusterMode")]
    public interface IElasticacheReplicationGroupClusterMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#num_node_groups ElasticacheReplicationGroup#num_node_groups}.</summary>
        [JsiiProperty(name: "numNodeGroups", typeJson: "{\"primitive\":\"number\"}")]
        double NumNodeGroups
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#replicas_per_node_group ElasticacheReplicationGroup#replicas_per_node_group}.</summary>
        [JsiiProperty(name: "replicasPerNodeGroup", typeJson: "{\"primitive\":\"number\"}")]
        double ReplicasPerNodeGroup
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticacheReplicationGroupClusterMode), fullyQualifiedName: "aws.elasticache.ElasticacheReplicationGroupClusterMode")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticache.IElasticacheReplicationGroupClusterMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#num_node_groups ElasticacheReplicationGroup#num_node_groups}.</summary>
            [JsiiProperty(name: "numNodeGroups", typeJson: "{\"primitive\":\"number\"}")]
            public double NumNodeGroups
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#replicas_per_node_group ElasticacheReplicationGroup#replicas_per_node_group}.</summary>
            [JsiiProperty(name: "replicasPerNodeGroup", typeJson: "{\"primitive\":\"number\"}")]
            public double ReplicasPerNodeGroup
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
