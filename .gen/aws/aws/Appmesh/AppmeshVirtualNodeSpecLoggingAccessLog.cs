using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLog")]
    public class AppmeshVirtualNodeSpecLoggingAccessLog : aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog
    {
        /// <summary>file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFile\"}", isOptional: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile? File
        {
            get;
            set;
        }
    }
}
