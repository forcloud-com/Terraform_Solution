using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualService), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualService")]
    public interface IAppmeshVirtualNodeSpecBackendVirtualService
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#virtual_service_name AppmeshVirtualNode#virtual_service_name}.</summary>
        [JsiiProperty(name: "virtualServiceName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualServiceName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualService), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualService")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#virtual_service_name AppmeshVirtualNode#virtual_service_name}.</summary>
            [JsiiProperty(name: "virtualServiceName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualServiceName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
