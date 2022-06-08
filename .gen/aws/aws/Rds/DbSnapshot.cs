using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot aws_db_snapshot}.</summary>
    [JsiiClass(nativeType: typeof(aws.Rds.DbSnapshot), fullyQualifiedName: "aws.rds.DbSnapshot", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.rds.DbSnapshotConfig\"}}]")]
    public class DbSnapshot : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot aws_db_snapshot} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DbSnapshot(Constructs.Construct scope, string id, aws.Rds.IDbSnapshotConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DbSnapshot(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DbSnapshot(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.rds.DbSnapshotTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Rds.IDbSnapshotTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Rds.IDbSnapshotTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.Rds.DbSnapshot))!;

        [JsiiProperty(name: "allocatedStorage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocatedStorage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSnapshotArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSnapshotArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Encrypted
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
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

        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Iops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "optionGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OptionGroupName
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

        [JsiiProperty(name: "sourceDbSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDbSnapshotIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.rds.DbSnapshotTimeoutsOutputReference\"}")]
        public virtual aws.Rds.DbSnapshotTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Rds.DbSnapshotTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbInstanceIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbInstanceIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbSnapshotIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbSnapshotIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.rds.DbSnapshotTimeouts\"}", isOptional: true)]
        public virtual aws.Rds.IDbSnapshotTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Rds.IDbSnapshotTimeouts?>();
        }

        [JsiiProperty(name: "dbInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbInstanceIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSnapshotIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
