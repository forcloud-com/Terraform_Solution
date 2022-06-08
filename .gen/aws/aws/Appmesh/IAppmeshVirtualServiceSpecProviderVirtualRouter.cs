using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualRouter), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouter")]
    public interface IAppmeshVirtualServiceSpecProviderVirtualRouter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_router_name AppmeshVirtualService#virtual_router_name}.</summary>
        [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualRouterName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualRouter), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouter")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_router_name AppmeshVirtualService#virtual_router_name}.</summary>
            [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualRouterName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
