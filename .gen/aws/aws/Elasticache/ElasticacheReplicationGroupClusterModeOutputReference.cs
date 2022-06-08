using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticache
{
    [JsiiClass(nativeType: typeof(aws.Elasticache.ElasticacheReplicationGroupClusterModeOutputReference), fullyQualifiedName: "aws.elasticache.ElasticacheReplicationGroupClusterModeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElasticacheReplicationGroupClusterModeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElasticacheReplicationGroupClusterModeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticacheReplicationGroupClusterModeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticacheReplicationGroupClusterModeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "numNodeGroupsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumNodeGroupsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicasPerNodeGroupInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicasPerNodeGroupInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "numNodeGroups", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumNodeGroups
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicasPerNodeGroup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicasPerNodeGroup
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupClusterMode\"}", isOptional: true)]
        public virtual aws.Elasticache.IElasticacheReplicationGroupClusterMode? InternalValue
        {
            get => GetInstanceProperty<aws.Elasticache.IElasticacheReplicationGroupClusterMode?>();
            set => SetInstanceProperty(value);
        }
    }
}
