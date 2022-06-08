using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudhsm
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/cloudhsm_v2_cluster aws_cloudhsm_v2_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudhsm.DataAwsCloudhsmV2Cluster), fullyQualifiedName: "aws.cloudhsm.DataAwsCloudhsmV2Cluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudhsm.DataAwsCloudhsmV2ClusterConfig\"}}]")]
    public class DataAwsCloudhsmV2Cluster : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/cloudhsm_v2_cluster aws_cloudhsm_v2_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsCloudhsmV2Cluster(Constructs.Construct scope, string id, aws.Cloudhsm.IDataAwsCloudhsmV2ClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudhsmV2Cluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudhsmV2Cluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClusterState")]
        public virtual void ResetClusterState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Cloudhsm.DataAwsCloudhsmV2Cluster))!;

        [JsiiProperty(name: "clusterCertificates", typeJson: "{\"fqn\":\"aws.cloudhsm.DataAwsCloudhsmV2ClusterClusterCertificatesList\"}")]
        public virtual aws.Cloudhsm.DataAwsCloudhsmV2ClusterClusterCertificatesList ClusterCertificates
        {
            get => GetInstanceProperty<aws.Cloudhsm.DataAwsCloudhsmV2ClusterClusterCertificatesList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
