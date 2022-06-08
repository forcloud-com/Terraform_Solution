using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscoveryDns), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDns")]
    public interface IAppmeshVirtualNodeSpecServiceDiscoveryDns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#hostname AppmeshVirtualNode#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#service_name AppmeshVirtualNode#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscoveryDns), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDns")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#hostname AppmeshVirtualNode#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#service_name AppmeshVirtualNode#service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
