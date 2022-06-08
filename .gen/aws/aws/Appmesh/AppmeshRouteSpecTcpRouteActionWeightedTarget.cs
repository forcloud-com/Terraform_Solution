using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecTcpRouteActionWeightedTarget")]
    public class AppmeshRouteSpecTcpRouteActionWeightedTarget : aws.Appmesh.IAppmeshRouteSpecTcpRouteActionWeightedTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#virtual_node AppmeshRoute#virtual_node}.</summary>
        [JsiiProperty(name: "virtualNode", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weight AppmeshRoute#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public double Weight
        {
            get;
            set;
        }
    }
}
