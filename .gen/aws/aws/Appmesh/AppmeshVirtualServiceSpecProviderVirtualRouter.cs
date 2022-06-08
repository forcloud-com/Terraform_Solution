using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouter")]
    public class AppmeshVirtualServiceSpecProviderVirtualRouter : aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_router_name AppmeshVirtualService#virtual_router_name}.</summary>
        [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualRouterName
        {
            get;
            set;
        }
    }
}
