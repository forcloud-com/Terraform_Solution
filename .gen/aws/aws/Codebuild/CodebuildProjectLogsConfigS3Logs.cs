using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectLogsConfigS3Logs")]
    public class CodebuildProjectLogsConfigS3Logs : aws.Codebuild.ICodebuildProjectLogsConfigS3Logs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#encryption_disabled CodebuildProject#encryption_disabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EncryptionDisabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#location CodebuildProject#location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#status CodebuildProject#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
