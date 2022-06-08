using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeaderMatch), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatch")]
    public interface IAppmeshRouteSpecHttpRouteMatchHeaderMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#exact AppmeshRoute#exact}.</summary>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exact
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#prefix AppmeshRoute#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#range AppmeshRoute#range}
        /// </remarks>
        [JsiiProperty(name: "range", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange? Range
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#regex AppmeshRoute#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Regex
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#suffix AppmeshRoute#suffix}.</summary>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Suffix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeaderMatch), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeaderMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#exact AppmeshRoute#exact}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exact
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#prefix AppmeshRoute#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#range AppmeshRoute#range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "range", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange? Range
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#regex AppmeshRoute#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Regex
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#suffix AppmeshRoute#suffix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Suffix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
