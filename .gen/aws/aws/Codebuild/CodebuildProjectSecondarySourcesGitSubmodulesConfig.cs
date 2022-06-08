using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectSecondarySourcesGitSubmodulesConfig")]
    public class CodebuildProjectSecondarySourcesGitSubmodulesConfig : aws.Codebuild.ICodebuildProjectSecondarySourcesGitSubmodulesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#fetch_submodules CodebuildProject#fetch_submodules}.</summary>
        [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object FetchSubmodules
        {
            get;
            set;
        }
    }
}
