using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualRouterSpecListener), fullyQualifiedName: "aws.appmesh.AppmeshVirtualRouterSpecListener")]
    public interface IAppmeshVirtualRouterSpecListener
    {
        /// <summary>port_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#port_mapping AppmeshVirtualRouter#port_mapping}
        /// </remarks>
        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListenerPortMapping\"}")]
        aws.Appmesh.IAppmeshVirtualRouterSpecListenerPortMapping PortMapping
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualRouterSpecListener), fullyQualifiedName: "aws.appmesh.AppmeshVirtualRouterSpecListener")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualRouterSpecListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>port_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#port_mapping AppmeshVirtualRouter#port_mapping}
            /// </remarks>
            [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListenerPortMapping\"}")]
            public aws.Appmesh.IAppmeshVirtualRouterSpecListenerPortMapping PortMapping
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualRouterSpecListenerPortMapping>()!;
            }
        }
    }
}
