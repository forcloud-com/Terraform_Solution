using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    /// <summary>AWS Relational Database Service.</summary>
    [JsiiInterface(nativeType: typeof(IDbSnapshotConfig), fullyQualifiedName: "aws.rds.DbSnapshotConfig")]
    public interface IDbSnapshotConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot#db_instance_identifier DbSnapshot#db_instance_identifier}.</summary>
        [JsiiProperty(name: "dbInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string DbInstanceIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot#db_snapshot_identifier DbSnapshot#db_snapshot_identifier}.</summary>
        [JsiiProperty(name: "dbSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string DbSnapshotIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot#tags DbSnapshot#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot#timeouts DbSnapshot#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.rds.DbSnapshotTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Rds.IDbSnapshotTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Relational Database Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDbSnapshotConfig), fullyQualifiedName: "aws.rds.DbSnapshotConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Rds.IDbSnapshotConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot#db_instance_identifier DbSnapshot#db_instance_identifier}.</summary>
            [JsiiProperty(name: "dbInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string DbInstanceIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot#db_snapshot_identifier DbSnapshot#db_snapshot_identifier}.</summary>
            [JsiiProperty(name: "dbSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string DbSnapshotIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot#tags DbSnapshot#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_snapshot#timeouts DbSnapshot#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.rds.DbSnapshotTimeouts\"}", isOptional: true)]
            public aws.Rds.IDbSnapshotTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Rds.IDbSnapshotTimeouts?>();
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
