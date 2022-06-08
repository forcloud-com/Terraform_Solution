using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectLogsConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectLogsConfig")]
    public interface ICodebuildProjectLogsConfig
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#cloudwatch_logs CodebuildProject#cloudwatch_logs}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigCloudwatchLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#s3_logs CodebuildProject#s3_logs}
        /// </remarks>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigS3Logs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codebuild.ICodebuildProjectLogsConfigS3Logs? S3Logs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectLogsConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectLogsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildProjectLogsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#cloudwatch_logs CodebuildProject#cloudwatch_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigCloudwatchLogs\"}", isOptional: true)]
            public aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs?>();
            }

            /// <summary>s3_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#s3_logs CodebuildProject#s3_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigS3Logs\"}", isOptional: true)]
            public aws.Codebuild.ICodebuildProjectLogsConfigS3Logs? S3Logs
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectLogsConfigS3Logs?>();
            }
        }
    }
}
