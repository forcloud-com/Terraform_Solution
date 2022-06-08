using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualNode), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualNode")]
    public interface IAppmeshVirtualServiceSpecProviderVirtualNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_node_name AppmeshVirtualService#virtual_node_name}.</summary>
        [JsiiProperty(name: "virtualNodeName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualNodeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualNode), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualNode")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_node_name AppmeshVirtualService#virtual_node_name}.</summary>
            [JsiiProperty(name: "virtualNodeName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualNodeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
