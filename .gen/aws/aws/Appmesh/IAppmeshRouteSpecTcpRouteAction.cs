using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecTcpRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecTcpRouteAction")]
    public interface IAppmeshRouteSpecTcpRouteAction
    {
        /// <summary>weighted_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
        /// </remarks>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteActionWeightedTarget\"},\"kind\":\"array\"}}]}}")]
        object WeightedTarget
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecTcpRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecTcpRouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecTcpRouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>weighted_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
            /// </remarks>
            [JsiiProperty(name: "weightedTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteActionWeightedTarget\"},\"kind\":\"array\"}}]}}")]
            public object WeightedTarget
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
