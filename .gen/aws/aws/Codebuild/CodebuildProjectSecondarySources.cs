using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectSecondarySources")]
    public class CodebuildProjectSecondarySources : aws.Codebuild.ICodebuildProjectSecondarySources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_identifier CodebuildProject#source_identifier}.</summary>
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#type CodebuildProject#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#auth CodebuildProject#auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySourcesAuth\"}", isOptional: true)]
        public aws.Codebuild.ICodebuildProjectSecondarySourcesAuth? Auth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#buildspec CodebuildProject#buildspec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "buildspec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Buildspec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#git_clone_depth CodebuildProject#git_clone_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gitCloneDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GitCloneDepth
        {
            get;
            set;
        }

        /// <summary>git_submodules_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#git_submodules_config CodebuildProject#git_submodules_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySourcesGitSubmodulesConfig\"}", isOptional: true)]
        public aws.Codebuild.ICodebuildProjectSecondarySourcesGitSubmodulesConfig? GitSubmodulesConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#insecure_ssl CodebuildProject#insecure_ssl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "insecureSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InsecureSsl
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#report_build_status CodebuildProject#report_build_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ReportBuildStatus
        {
            get;
            set;
        }
    }
}
