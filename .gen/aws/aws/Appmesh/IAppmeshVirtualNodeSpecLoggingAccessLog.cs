using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLog), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLog")]
    public interface IAppmeshVirtualNodeSpecLoggingAccessLog
    {
        /// <summary>file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile? File
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLog), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLog")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFile\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile? File
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile?>();
            }
        }
    }
}
