using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Neptune
{
    [JsiiInterface(nativeType: typeof(INeptuneClusterSnapshotTimeouts), fullyQualifiedName: "aws.neptune.NeptuneClusterSnapshotTimeouts")]
    public interface INeptuneClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_snapshot#create NeptuneClusterSnapshot#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INeptuneClusterSnapshotTimeouts), fullyQualifiedName: "aws.neptune.NeptuneClusterSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Neptune.INeptuneClusterSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_snapshot#create NeptuneClusterSnapshot#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
