using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Documentdb
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_snapshot aws_docdb_cluster_snapshot}.</summary>
    [JsiiClass(nativeType: typeof(aws.Documentdb.DocdbClusterSnapshot), fullyQualifiedName: "aws.documentdb.DocdbClusterSnapshot", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.documentdb.DocdbClusterSnapshotConfig\"}}]")]
    public class DocdbClusterSnapshot : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_snapshot aws_docdb_cluster_snapshot} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DocdbClusterSnapshot(Constructs.Construct scope, string id, aws.Documentdb.IDocdbClusterSnapshotConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DocdbClusterSnapshot(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DocdbClusterSnapshot(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.documentdb.DocdbClusterSnapshotTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Documentdb.IDocdbClusterSnapshotTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Documentdb.IDocdbClusterSnapshotTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Documentdb.DocdbClusterSnapshot))!;

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dbClusterSnapshotArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbClusterSnapshotArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Engine
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "snapshotType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDbClusterSnapshotArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDbClusterSnapshotArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageEncrypted", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable StorageEncrypted
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.documentdb.DocdbClusterSnapshotTimeoutsOutputReference\"}")]
        public virtual aws.Documentdb.DocdbClusterSnapshotTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Documentdb.DocdbClusterSnapshotTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbClusterIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbClusterIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbClusterSnapshotIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbClusterSnapshotIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.documentdb.DocdbClusterSnapshotTimeouts\"}", isOptional: true)]
        public virtual aws.Documentdb.IDocdbClusterSnapshotTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Documentdb.IDocdbClusterSnapshotTimeouts?>();
        }

        [JsiiProperty(name: "dbClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbClusterIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbClusterSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbClusterSnapshotIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
