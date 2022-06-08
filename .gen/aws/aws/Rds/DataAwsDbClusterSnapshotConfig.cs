using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    /// <summary>AWS Relational Database Service.</summary>
    [JsiiByValue(fqn: "aws.rds.DataAwsDbClusterSnapshotConfig")]
    public class DataAwsDbClusterSnapshotConfig : aws.Rds.IDataAwsDbClusterSnapshotConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#db_cluster_identifier DataAwsDbClusterSnapshot#db_cluster_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbClusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#db_cluster_snapshot_identifier DataAwsDbClusterSnapshot#db_cluster_snapshot_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbClusterSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbClusterSnapshotIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#include_public DataAwsDbClusterSnapshot#include_public}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includePublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludePublic
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#include_shared DataAwsDbClusterSnapshot#include_shared}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeShared", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeShared
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#most_recent DataAwsDbClusterSnapshot#most_recent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mostRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MostRecent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#snapshot_type DataAwsDbClusterSnapshot#snapshot_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/db_cluster_snapshot#tags DataAwsDbClusterSnapshot#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
