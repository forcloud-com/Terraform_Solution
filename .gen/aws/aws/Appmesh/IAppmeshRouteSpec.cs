using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpec), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpec")]
    public interface IAppmeshRouteSpec
    {
        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http_route AppmeshRoute#http_route}
        /// </remarks>
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttpRoute? HttpRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#priority AppmeshRoute#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#tcp_route AppmeshRoute#tcp_route}
        /// </remarks>
        [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecTcpRoute? TcpRoute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpec), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpec")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>http_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http_route AppmeshRoute#http_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttpRoute? HttpRoute
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRoute?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#priority AppmeshRoute#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>tcp_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#tcp_route AppmeshRoute#tcp_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecTcpRoute? TcpRoute
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecTcpRoute?>();
            }
        }
    }
}
