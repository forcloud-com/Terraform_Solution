using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListener), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListener")]
    public interface IAppmeshVirtualNodeSpecListener
    {
        /// <summary>port_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#port_mapping AppmeshVirtualNode#port_mapping}
        /// </remarks>
        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMapping\"}")]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping PortMapping
        {
            get;
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#health_check AppmeshVirtualNode#health_check}
        /// </remarks>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck? HealthCheck
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListener), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListener")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>port_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#port_mapping AppmeshVirtualNode#port_mapping}
            /// </remarks>
            [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMapping\"}")]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping PortMapping
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping>()!;
            }

            /// <summary>health_check block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#health_check AppmeshVirtualNode#health_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheck\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck? HealthCheck
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck?>();
            }
        }
    }
}
