using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualService")]
    public class AppmeshVirtualNodeSpecBackendVirtualService : aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualService
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#virtual_service_name AppmeshVirtualNode#virtual_service_name}.</summary>
        [JsiiProperty(name: "virtualServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualServiceName
        {
            get;
            set;
        }
    }
}
