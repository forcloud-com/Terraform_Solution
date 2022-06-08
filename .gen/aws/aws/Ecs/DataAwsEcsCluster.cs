using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/ecs_cluster aws_ecs_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecs.DataAwsEcsCluster), fullyQualifiedName: "aws.ecs.DataAwsEcsCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecs.DataAwsEcsClusterConfig\"}}]")]
    public class DataAwsEcsCluster : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/ecs_cluster aws_ecs_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEcsCluster(Constructs.Construct scope, string id, aws.Ecs.IDataAwsEcsClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsCluster(DeputyProps props): base(props)
        {
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
        = GetStaticProperty<string>(typeof(aws.Ecs.DataAwsEcsCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pendingTasksCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PendingTasksCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "registeredContainerInstancesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RegisteredContainerInstancesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "runningTasksCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RunningTasksCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "setting", typeJson: "{\"fqn\":\"aws.ecs.DataAwsEcsClusterSettingList\"}")]
        public virtual aws.Ecs.DataAwsEcsClusterSettingList Setting
        {
            get => GetInstanceProperty<aws.Ecs.DataAwsEcsClusterSettingList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
