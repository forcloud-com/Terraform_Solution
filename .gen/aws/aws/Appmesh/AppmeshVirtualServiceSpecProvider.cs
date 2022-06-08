using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualServiceSpecProvider")]
    public class AppmeshVirtualServiceSpecProvider : aws.Appmesh.IAppmeshVirtualServiceSpecProvider
    {
        /// <summary>virtual_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_node AppmeshVirtualService#virtual_node}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNode", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualNode\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode? VirtualNode
        {
            get;
            set;
        }

        /// <summary>virtual_router block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#virtual_router AppmeshVirtualService#virtual_router}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualRouter", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouter\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter? VirtualRouter
        {
            get;
            set;
        }
    }
}
