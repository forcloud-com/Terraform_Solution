using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    [JsiiByValue(fqn: "aws.rds.DbClusterSnapshotTimeouts")]
    public class DbClusterSnapshotTimeouts : aws.Rds.IDbClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_cluster_snapshot#create DbClusterSnapshot#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
