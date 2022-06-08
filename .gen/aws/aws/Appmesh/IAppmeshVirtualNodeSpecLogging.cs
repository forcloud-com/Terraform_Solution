using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecLogging), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecLogging")]
    public interface IAppmeshVirtualNodeSpecLogging
    {
        /// <summary>access_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#access_log AppmeshVirtualNode#access_log}
        /// </remarks>
        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog? AccessLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecLogging), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecLogging")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#access_log AppmeshVirtualNode#access_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLog\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog? AccessLog
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog?>();
            }
        }
    }
}
