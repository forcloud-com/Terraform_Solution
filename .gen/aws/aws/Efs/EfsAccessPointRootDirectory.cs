using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiByValue(fqn: "aws.efs.EfsAccessPointRootDirectory")]
    public class EfsAccessPointRootDirectory : aws.Efs.IEfsAccessPointRootDirectory
    {
        /// <summary>creation_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#creation_info EfsAccessPoint#creation_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "creationInfo", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectoryCreationInfo\"}", isOptional: true)]
        public aws.Efs.IEfsAccessPointRootDirectoryCreationInfo? CreationInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#path EfsAccessPoint#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
