using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange")]
    public interface IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#end AppmeshRoute#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
        double End
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#start AppmeshRoute#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        double Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#end AppmeshRoute#end}.</summary>
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
            public double End
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#start AppmeshRoute#start}.</summary>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
            public double Start
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
