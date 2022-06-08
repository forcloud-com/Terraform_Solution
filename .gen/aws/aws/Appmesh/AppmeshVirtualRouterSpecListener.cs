using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualRouterSpecListener")]
    public class AppmeshVirtualRouterSpecListener : aws.Appmesh.IAppmeshVirtualRouterSpecListener
    {
        /// <summary>port_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#port_mapping AppmeshVirtualRouter#port_mapping}
        /// </remarks>
        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListenerPortMapping\"}")]
        public aws.Appmesh.IAppmeshVirtualRouterSpecListenerPortMapping PortMapping
        {
            get;
            set;
        }
    }
}
