using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatch")]
    public class AppmeshRouteSpecHttpRouteMatchHeaderMatch : aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeaderMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#exact AppmeshRoute#exact}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Exact
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#prefix AppmeshRoute#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#range AppmeshRoute#range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "range", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange? Range
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#regex AppmeshRoute#regex}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Regex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#suffix AppmeshRoute#suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Suffix
        {
            get;
            set;
        }
    }
}
