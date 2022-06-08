using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscovery), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecServiceDiscovery")]
    public interface IAppmeshVirtualNodeSpecServiceDiscovery
    {
        /// <summary>aws_cloud_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#aws_cloud_map AppmeshVirtualNode#aws_cloud_map}
        /// </remarks>
        [JsiiProperty(name: "awsCloudMap", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap? AwsCloudMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>dns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#dns AppmeshVirtualNode#dns}
        /// </remarks>
        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns? Dns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscovery), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecServiceDiscovery")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_cloud_map block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#aws_cloud_map AppmeshVirtualNode#aws_cloud_map}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsCloudMap", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap? AwsCloudMap
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap?>();
            }

            /// <summary>dns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#dns AppmeshVirtualNode#dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDns\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns? Dns
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns?>();
            }
        }
    }
}
