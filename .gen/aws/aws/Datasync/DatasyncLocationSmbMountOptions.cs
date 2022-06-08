using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    [JsiiByValue(fqn: "aws.datasync.DatasyncLocationSmbMountOptions")]
    public class DatasyncLocationSmbMountOptions : aws.Datasync.IDatasyncLocationSmbMountOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#version DatasyncLocationSmb#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
