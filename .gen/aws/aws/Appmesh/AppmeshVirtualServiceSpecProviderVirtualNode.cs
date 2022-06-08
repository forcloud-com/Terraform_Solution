using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualNode")]
    public class AppmeshVirtualServiceSpecProviderVirtualNode : aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_node_name AppmeshVirtualService#virtual_node_name}.</summary>
        [JsiiProperty(name: "virtualNodeName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualNodeName
        {
            get;
            set;
        }
    }
}
