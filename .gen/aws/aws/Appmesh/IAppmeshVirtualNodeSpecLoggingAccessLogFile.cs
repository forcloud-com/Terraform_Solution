using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLogFile), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFile")]
    public interface IAppmeshVirtualNodeSpecLoggingAccessLogFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#path AppmeshVirtualNode#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLogFile), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFile")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#path AppmeshVirtualNode#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
