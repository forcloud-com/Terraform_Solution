using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster aws_redshift_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.Redshift.RedshiftCluster), fullyQualifiedName: "aws.redshift.RedshiftCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.redshift.RedshiftClusterConfig\"}}]")]
    public class RedshiftCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster aws_redshift_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public RedshiftCluster(Constructs.Construct scope, string id, aws.Redshift.IRedshiftClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedshiftCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedshiftCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.redshift.RedshiftClusterLogging\"}}]")]
        public virtual void PutLogging(aws.Redshift.IRedshiftClusterLogging @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Redshift.IRedshiftClusterLogging)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshotCopy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.redshift.RedshiftClusterSnapshotCopy\"}}]")]
        public virtual void PutSnapshotCopy(aws.Redshift.IRedshiftClusterSnapshotCopy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Redshift.IRedshiftClusterSnapshotCopy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.redshift.RedshiftClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Redshift.IRedshiftClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Redshift.IRedshiftClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowVersionUpgrade")]
        public virtual void ResetAllowVersionUpgrade()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomatedSnapshotRetentionPeriod")]
        public virtual void ResetAutomatedSnapshotRetentionPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityZone")]
        public virtual void ResetAvailabilityZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucketName")]
        public virtual void ResetBucketName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterParameterGroupName")]
        public virtual void ResetClusterParameterGroupName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterPublicKey")]
        public virtual void ResetClusterPublicKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterRevisionNumber")]
        public virtual void ResetClusterRevisionNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterSecurityGroups")]
        public virtual void ResetClusterSecurityGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterSubnetGroupName")]
        public virtual void ResetClusterSubnetGroupName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterType")]
        public virtual void ResetClusterType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterVersion")]
        public virtual void ResetClusterVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseName")]
        public virtual void ResetDatabaseName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticIp")]
        public virtual void ResetElasticIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableLogging")]
        public virtual void ResetEnableLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncrypted")]
        public virtual void ResetEncrypted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpoint")]
        public virtual void ResetEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnhancedVpcRouting")]
        public virtual void ResetEnhancedVpcRouting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFinalSnapshotIdentifier")]
        public virtual void ResetFinalSnapshotIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamRoles")]
        public virtual void ResetIamRoles()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterPassword")]
        public virtual void ResetMasterPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterUsername")]
        public virtual void ResetMasterUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberOfNodes")]
        public virtual void ResetNumberOfNodes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwnerAccount")]
        public virtual void ResetOwnerAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredMaintenanceWindow")]
        public virtual void ResetPreferredMaintenanceWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPubliclyAccessible")]
        public virtual void ResetPubliclyAccessible()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3KeyPrefix")]
        public virtual void ResetS3KeyPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipFinalSnapshot")]
        public virtual void ResetSkipFinalSnapshot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotClusterIdentifier")]
        public virtual void ResetSnapshotClusterIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotCopy")]
        public virtual void ResetSnapshotCopy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotIdentifier")]
        public virtual void ResetSnapshotIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetVpcSecurityGroupIds")]
        public virtual void ResetVpcSecurityGroupIds()
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
        = GetStaticProperty<string>(typeof(aws.Redshift.RedshiftCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterLoggingOutputReference\"}")]
        public virtual aws.Redshift.RedshiftClusterLoggingOutputReference Logging
        {
            get => GetInstanceProperty<aws.Redshift.RedshiftClusterLoggingOutputReference>()!;
        }

        [JsiiProperty(name: "snapshotCopy", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterSnapshotCopyOutputReference\"}")]
        public virtual aws.Redshift.RedshiftClusterSnapshotCopyOutputReference SnapshotCopy
        {
            get => GetInstanceProperty<aws.Redshift.RedshiftClusterSnapshotCopyOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterTimeoutsOutputReference\"}")]
        public virtual aws.Redshift.RedshiftClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Redshift.RedshiftClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowVersionUpgradeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowVersionUpgradeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automatedSnapshotRetentionPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutomatedSnapshotRetentionPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterParameterGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterParameterGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterPublicKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterPublicKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterRevisionNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterRevisionNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterSecurityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ClusterSecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterSubnetGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterSubnetGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ElasticIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableLoggingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableLoggingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EncryptedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enhancedVpcRoutingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnhancedVpcRoutingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "finalSnapshotIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FinalSnapshotIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamRolesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IamRolesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterLogging\"}", isOptional: true)]
        public virtual aws.Redshift.IRedshiftClusterLogging? LoggingInput
        {
            get => GetInstanceProperty<aws.Redshift.IRedshiftClusterLogging?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfNodesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfNodesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnerAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredMaintenanceWindowInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreferredMaintenanceWindowInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessibleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PubliclyAccessibleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3KeyPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipFinalSnapshotInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SkipFinalSnapshotInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotClusterIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotClusterIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotCopyInput", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterSnapshotCopy\"}", isOptional: true)]
        public virtual aws.Redshift.IRedshiftClusterSnapshotCopy? SnapshotCopyInput
        {
            get => GetInstanceProperty<aws.Redshift.IRedshiftClusterSnapshotCopy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotIdentifierInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterTimeouts\"}", isOptional: true)]
        public virtual aws.Redshift.IRedshiftClusterTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Redshift.IRedshiftClusterTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "allowVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AllowVersionUpgrade
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "automatedSnapshotRetentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutomatedSnapshotRetentionPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterParameterGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterParameterGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPublicKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterRevisionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterRevisionNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterSecurityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClusterSecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterSubnetGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterSubnetGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableLogging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableLogging
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Encrypted
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enhancedVpcRouting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnhancedVpcRouting
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "finalSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FinalSnapshotIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IamRoles
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberOfNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfNodes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ownerAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerAccount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredMaintenanceWindow
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PubliclyAccessible
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3KeyPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skipFinalSnapshot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SkipFinalSnapshot
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotClusterIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotIdentifier
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

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
