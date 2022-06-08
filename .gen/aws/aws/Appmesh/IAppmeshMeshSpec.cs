using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshMeshSpec), fullyQualifiedName: "aws.appmesh.AppmeshMeshSpec")]
    public interface IAppmeshMeshSpec
    {
        /// <summary>egress_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_mesh#egress_filter AppmeshMesh#egress_filter}
        /// </remarks>
        [JsiiProperty(name: "egressFilter", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshMeshSpecEgressFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshMeshSpecEgressFilter? EgressFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshMeshSpec), fullyQualifiedName: "aws.appmesh.AppmeshMeshSpec")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshMeshSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>egress_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_mesh#egress_filter AppmeshMesh#egress_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "egressFilter", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshMeshSpecEgressFilter\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshMeshSpecEgressFilter? EgressFilter
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshMeshSpecEgressFilter?>();
            }
        }
    }
}
