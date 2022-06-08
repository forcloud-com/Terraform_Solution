using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange")]
    public class AppmeshRouteSpecHttpRouteMatchHeaderMatchRange : aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#end AppmeshRoute#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
        public double End
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#start AppmeshRoute#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        public double Start
        {
            get;
            set;
        }
    }
}
