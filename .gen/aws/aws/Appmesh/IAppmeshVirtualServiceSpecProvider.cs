using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpecProvider), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpecProvider")]
    public interface IAppmeshVirtualServiceSpecProvider
    {
        /// <summary>virtual_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_node AppmeshVirtualService#virtual_node}
        /// </remarks>
        [JsiiProperty(name: "virtualNode", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualNode\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode? VirtualNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_router block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_router AppmeshVirtualService#virtual_router}
        /// </remarks>
        [JsiiProperty(name: "virtualRouter", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter? VirtualRouter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpecProvider), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpecProvider")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualServiceSpecProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>virtual_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_node AppmeshVirtualService#virtual_node}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNode", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualNode\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode? VirtualNode
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode?>();
            }

            /// <summary>virtual_router block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_router AppmeshVirtualService#virtual_router}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualRouter", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouter\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter? VirtualRouter
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter?>();
            }
        }
    }
}
