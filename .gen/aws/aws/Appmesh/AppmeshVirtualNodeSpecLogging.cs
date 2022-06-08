using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecLogging")]
    public class AppmeshVirtualNodeSpecLogging : aws.Appmesh.IAppmeshVirtualNodeSpecLogging
    {
        /// <summary>access_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#access_log AppmeshVirtualNode#access_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLog\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog? AccessLog
        {
            get;
            set;
        }
    }
}
