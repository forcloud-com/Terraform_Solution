using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpec")]
    public class AppmeshVirtualNodeSpec : aws.Appmesh.IAppmeshVirtualNodeSpec
    {
        /// <summary>backend block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#backend AppmeshVirtualNode#backend}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backend", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackend\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Backend
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#backends AppmeshVirtualNode#backends}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backends", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Backends
        {
            get;
            set;
        }

        /// <summary>listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#listener AppmeshVirtualNode#listener}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListener\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListener? Listener
        {
            get;
            set;
        }

        /// <summary>logging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#logging AppmeshVirtualNode#logging}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLogging\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecLogging? Logging
        {
            get;
            set;
        }

        /// <summary>service_discovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#service_discovery AppmeshVirtualNode#service_discovery}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscovery\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery? ServiceDiscovery
        {
            get;
            set;
        }
    }
}
