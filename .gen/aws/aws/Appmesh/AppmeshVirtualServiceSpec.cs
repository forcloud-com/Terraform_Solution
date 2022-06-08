using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualServiceSpec")]
    public class AppmeshVirtualServiceSpec : aws.Appmesh.IAppmeshVirtualServiceSpec
    {
        /// <summary>provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_service#provider AppmeshVirtualService#provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualServiceSpecProvider? Provider
        {
            get;
            set;
        }
    }
}
