using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap")]
    public class AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap : aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#namespace_name AppmeshVirtualNode#namespace_name}.</summary>
        [JsiiProperty(name: "namespaceName", typeJson: "{\"primitive\":\"string\"}")]
        public string NamespaceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#service_name AppmeshVirtualNode#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#attributes AppmeshVirtualNode#attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Attributes
        {
            get;
            set;
        }
    }
}
