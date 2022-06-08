using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecServiceDiscovery")]
    public class AppmeshVirtualNodeSpecServiceDiscovery : aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery
    {
        /// <summary>aws_cloud_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#aws_cloud_map AppmeshVirtualNode#aws_cloud_map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsCloudMap", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap? AwsCloudMap
        {
            get;
            set;
        }

        /// <summary>dns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#dns AppmeshVirtualNode#dns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDns\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns? Dns
        {
            get;
            set;
        }
    }
}
