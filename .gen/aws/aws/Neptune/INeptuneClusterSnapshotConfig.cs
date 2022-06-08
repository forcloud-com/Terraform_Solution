using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Neptune
{
    /// <summary>AWS Neptune.</summary>
    [JsiiInterface(nativeType: typeof(INeptuneClusterSnapshotConfig), fullyQualifiedName: "aws.neptune.NeptuneClusterSnapshotConfig")]
    public interface INeptuneClusterSnapshotConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_snapshot#db_cluster_identifier NeptuneClusterSnapshot#db_cluster_identifier}.</summary>
        [JsiiProperty(name: "dbClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string DbClusterIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_snapshot#db_cluster_snapshot_identifier NeptuneClusterSnapshot#db_cluster_snapshot_identifier}.</summary>
        [JsiiProperty(name: "dbClusterSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string DbClusterSnapshotIdentifier
        {
            get;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_snapshot#timeouts NeptuneClusterSnapshot#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.neptune.NeptuneClusterSnapshotTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Neptune.INeptuneClusterSnapshotTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Neptune.</summary>
        [JsiiTypeProxy(nativeType: typeof(INeptuneClusterSnapshotConfig), fullyQualifiedName: "aws.neptune.NeptuneClusterSnapshotConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Neptune.INeptuneClusterSnapshotConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_snapshot#db_cluster_identifier NeptuneClusterSnapshot#db_cluster_identifier}.</summary>
            [JsiiProperty(name: "dbClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string DbClusterIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_snapshot#db_cluster_snapshot_identifier NeptuneClusterSnapshot#db_cluster_snapshot_identifier}.</summary>
            [JsiiProperty(name: "dbClusterSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string DbClusterSnapshotIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_snapshot#timeouts NeptuneClusterSnapshot#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.neptune.NeptuneClusterSnapshotTimeouts\"}", isOptional: true)]
            public aws.Neptune.INeptuneClusterSnapshotTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Neptune.INeptuneClusterSnapshotTimeouts?>();
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
