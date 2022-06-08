using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Documentdb
{
    #pragma warning disable CS8618

    /// <summary>AWS DocumentDB.</summary>
    [JsiiByValue(fqn: "aws.documentdb.DocdbClusterSnapshotConfig")]
    public class DocdbClusterSnapshotConfig : aws.Documentdb.IDocdbClusterSnapshotConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_snapshot#db_cluster_identifier DocdbClusterSnapshot#db_cluster_identifier}.</summary>
        [JsiiProperty(name: "dbClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string DbClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_snapshot#db_cluster_snapshot_identifier DocdbClusterSnapshot#db_cluster_snapshot_identifier}.</summary>
        [JsiiProperty(name: "dbClusterSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string DbClusterSnapshotIdentifier
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_snapshot#timeouts DocdbClusterSnapshot#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.documentdb.DocdbClusterSnapshotTimeouts\"}", isOptional: true)]
        public aws.Documentdb.IDocdbClusterSnapshotTimeouts? Timeouts
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
