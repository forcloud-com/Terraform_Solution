using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshMeshSpec")]
    public class AppmeshMeshSpec : aws.Appmesh.IAppmeshMeshSpec
    {
        /// <summary>egress_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_mesh#egress_filter AppmeshMesh#egress_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "egressFilter", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshMeshSpecEgressFilter\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshMeshSpecEgressFilter? EgressFilter
        {
            get;
            set;
        }
    }
}
