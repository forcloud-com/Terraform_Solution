using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpec), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpec")]
    public interface IAppmeshVirtualServiceSpec
    {
        /// <summary>provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#provider AppmeshVirtualService#provider}
        /// </remarks>
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualServiceSpecProvider? Provider
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpec), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpec")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualServiceSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#provider AppmeshVirtualService#provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualServiceSpecProvider? Provider
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualServiceSpecProvider?>();
            }
        }
    }
}
