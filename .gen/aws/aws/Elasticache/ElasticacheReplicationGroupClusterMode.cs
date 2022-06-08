using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticache.ElasticacheReplicationGroupClusterMode")]
    public class ElasticacheReplicationGroupClusterMode : aws.Elasticache.IElasticacheReplicationGroupClusterMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#num_node_groups ElasticacheReplicationGroup#num_node_groups}.</summary>
        [JsiiProperty(name: "numNodeGroups", typeJson: "{\"primitive\":\"number\"}")]
        public double NumNodeGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#replicas_per_node_group ElasticacheReplicationGroup#replicas_per_node_group}.</summary>
        [JsiiProperty(name: "replicasPerNodeGroup", typeJson: "{\"primitive\":\"number\"}")]
        public double ReplicasPerNodeGroup
        {
            get;
            set;
        }
    }
}
