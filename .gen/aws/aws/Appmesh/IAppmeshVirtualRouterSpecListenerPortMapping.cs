using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualRouterSpecListenerPortMapping), fullyQualifiedName: "aws.appmesh.AppmeshVirtualRouterSpecListenerPortMapping")]
    public interface IAppmeshVirtualRouterSpecListenerPortMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#port AppmeshVirtualRouter#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#protocol AppmeshVirtualRouter#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualRouterSpecListenerPortMapping), fullyQualifiedName: "aws.appmesh.AppmeshVirtualRouterSpecListenerPortMapping")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualRouterSpecListenerPortMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#port AppmeshVirtualRouter#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#protocol AppmeshVirtualRouter#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
