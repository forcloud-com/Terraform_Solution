using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFile")]
    public class AppmeshVirtualNodeSpecLoggingAccessLogFile : aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#path AppmeshVirtualNode#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}
