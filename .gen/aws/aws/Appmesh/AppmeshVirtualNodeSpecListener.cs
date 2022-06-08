using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListener")]
    public class AppmeshVirtualNodeSpecListener : aws.Appmesh.IAppmeshVirtualNodeSpecListener
    {
        /// <summary>port_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#port_mapping AppmeshVirtualNode#port_mapping}
        /// </remarks>
        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMapping\"}")]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping PortMapping
        {
            get;
            set;
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#health_check AppmeshVirtualNode#health_check}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheck\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck? HealthCheck
        {
            get;
            set;
        }
    }
}
