using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Documentdb
{
    [JsiiInterface(nativeType: typeof(IDocdbClusterSnapshotTimeouts), fullyQualifiedName: "aws.documentdb.DocdbClusterSnapshotTimeouts")]
    public interface IDocdbClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_snapshot#create DocdbClusterSnapshot#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDocdbClusterSnapshotTimeouts), fullyQualifiedName: "aws.documentdb.DocdbClusterSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Documentdb.IDocdbClusterSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_snapshot#create DocdbClusterSnapshot#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
