using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Documentdb
{
    [JsiiByValue(fqn: "aws.documentdb.DocdbClusterSnapshotTimeouts")]
    public class DocdbClusterSnapshotTimeouts : aws.Documentdb.IDocdbClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_snapshot#create DocdbClusterSnapshot#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
