using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectLogsConfigCloudwatchLogs), fullyQualifiedName: "aws.codebuild.CodebuildProjectLogsConfigCloudwatchLogs")]
    public interface ICodebuildProjectLogsConfigCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#group_name CodebuildProject#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#status CodebuildProject#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#stream_name CodebuildProject#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectLogsConfigCloudwatchLogs), fullyQualifiedName: "aws.codebuild.CodebuildProjectLogsConfigCloudwatchLogs")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#group_name CodebuildProject#group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#status CodebuildProject#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#stream_name CodebuildProject#stream_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
