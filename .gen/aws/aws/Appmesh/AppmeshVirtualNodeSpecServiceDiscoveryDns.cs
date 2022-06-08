using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDns")]
    public class AppmeshVirtualNodeSpecServiceDiscoveryDns : aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#hostname AppmeshVirtualNode#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public string Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#service_name AppmeshVirtualNode#service_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceName
        {
            get;
            set;
        }
    }
}
