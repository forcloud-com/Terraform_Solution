using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteActionWeightedTarget), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteActionWeightedTarget")]
    public interface IAppmeshRouteSpecHttpRouteActionWeightedTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#virtual_node AppmeshRoute#virtual_node}.</summary>
        [JsiiProperty(name: "virtualNode", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualNode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weight AppmeshRoute#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteActionWeightedTarget), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteActionWeightedTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttpRouteActionWeightedTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#virtual_node AppmeshRoute#virtual_node}.</summary>
            [JsiiProperty(name: "virtualNode", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualNode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weight AppmeshRoute#weight}.</summary>
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
