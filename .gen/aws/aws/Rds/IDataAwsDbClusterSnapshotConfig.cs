using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    /// <summary>AWS Relational Database Service.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsDbClusterSnapshotConfig), fullyQualifiedName: "aws.rds.DataAwsDbClusterSnapshotConfig")]
    public interface IDataAwsDbClusterSnapshotConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#db_cluster_identifier DataAwsDbClusterSnapshot#db_cluster_identifier}.</summary>
        [JsiiProperty(name: "dbClusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbClusterIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#db_cluster_snapshot_identifier DataAwsDbClusterSnapshot#db_cluster_snapshot_identifier}.</summary>
        [JsiiProperty(name: "dbClusterSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbClusterSnapshotIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#include_public DataAwsDbClusterSnapshot#include_public}.</summary>
        [JsiiProperty(name: "includePublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludePublic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#include_shared DataAwsDbClusterSnapshot#include_shared}.</summary>
        [JsiiProperty(name: "includeShared", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeShared
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#most_recent DataAwsDbClusterSnapshot#most_recent}.</summary>
        [JsiiProperty(name: "mostRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MostRecent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#snapshot_type DataAwsDbClusterSnapshot#snapshot_type}.</summary>
        [JsiiProperty(name: "snapshotType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnapshotType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#tags DataAwsDbClusterSnapshot#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Relational Database Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsDbClusterSnapshotConfig), fullyQualifiedName: "aws.rds.DataAwsDbClusterSnapshotConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Rds.IDataAwsDbClusterSnapshotConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#db_cluster_identifier DataAwsDbClusterSnapshot#db_cluster_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbClusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbClusterIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#db_cluster_snapshot_identifier DataAwsDbClusterSnapshot#db_cluster_snapshot_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbClusterSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbClusterSnapshotIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#include_public DataAwsDbClusterSnapshot#include_public}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includePublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludePublic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#include_shared DataAwsDbClusterSnapshot#include_shared}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeShared", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeShared
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#most_recent DataAwsDbClusterSnapshot#most_recent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mostRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MostRecent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#snapshot_type DataAwsDbClusterSnapshot#snapshot_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnapshotType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#tags DataAwsDbClusterSnapshot#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
