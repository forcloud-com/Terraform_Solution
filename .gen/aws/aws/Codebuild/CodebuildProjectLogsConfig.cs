using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectLogsConfig")]
    public class CodebuildProjectLogsConfig : aws.Codebuild.ICodebuildProjectLogsConfig
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#cloudwatch_logs CodebuildProject#cloudwatch_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigCloudwatchLogs\"}", isOptional: true)]
        public aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#s3_logs CodebuildProject#s3_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigS3Logs\"}", isOptional: true)]
        public aws.Codebuild.ICodebuildProjectLogsConfigS3Logs? S3Logs
        {
            get;
            set;
        }
    }
}
