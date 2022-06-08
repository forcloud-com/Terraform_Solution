using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRoute), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRoute")]
    public interface IAppmeshRouteSpecHttpRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteAction\"}")]
        aws.Appmesh.IAppmeshRouteSpecHttpRouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatch\"}")]
        aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch Match
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRoute), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRoute")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttpRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteAction\"}")]
            public aws.Appmesh.IAppmeshRouteSpecHttpRouteAction Action
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatch\"}")]
            public aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch Match
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch>()!;
            }
        }
    }
}
