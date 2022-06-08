using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttpRouteAction")]
    public class AppmeshRouteSpecHttpRouteAction : aws.Appmesh.IAppmeshRouteSpecHttpRouteAction
    {
        /// <summary>weighted_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
        /// </remarks>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteActionWeightedTarget\"},\"kind\":\"array\"}}]}}")]
        public object WeightedTarget
        {
            get;
            set;
        }
    }
}
