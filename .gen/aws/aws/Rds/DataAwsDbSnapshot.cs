using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/db_snapshot aws_db_snapshot}.</summary>
    [JsiiClass(nativeType: typeof(aws.Rds.DataAwsDbSnapshot), fullyQualifiedName: "aws.rds.DataAwsDbSnapshot", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.rds.DataAwsDbSnapshotConfig\"}}]")]
    public class DataAwsDbSnapshot : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/db_snapshot aws_db_snapshot} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsDbSnapshot(Constructs.Construct scope, string id, aws.Rds.IDataAwsDbSnapshotConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDbSnapshot(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDbSnapshot(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDbInstanceIdentifier")]
        public virtual void ResetDbInstanceIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbSnapshotIdentifier")]
        public virtual void ResetDbSnapshotIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludePublic")]
        public virtual void ResetIncludePublic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeShared")]
        public virtual void ResetIncludeShared()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMostRecent")]
        public virtual void ResetMostRecent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotType")]
        public virtual void ResetSnapshotType()
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
        = GetStaticProperty<string>(typeof(aws.Rds.DataAwsDbSnapshot))!;

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

        [JsiiProperty(name: "snapshotCreateTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotCreateTime
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
        [JsiiProperty(name: "includePublicInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IncludePublicInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeSharedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IncludeSharedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mostRecentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MostRecentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotTypeInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "includePublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IncludePublic
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeShared", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IncludeShared
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mostRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object MostRecent
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
