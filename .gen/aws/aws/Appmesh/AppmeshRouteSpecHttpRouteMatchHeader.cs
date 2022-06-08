using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeader")]
    public class AppmeshRouteSpecHttpRouteMatchHeader : aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#name AppmeshRoute#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#invert AppmeshRoute#invert}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "invert", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Invert
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatch\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeaderMatch? Match
        {
            get;
            set;
        }
    }
}
