using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSecondarySourcesGitSubmodulesConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectSecondarySourcesGitSubmodulesConfig")]
    public interface ICodebuildProjectSecondarySourcesGitSubmodulesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#fetch_submodules CodebuildProject#fetch_submodules}.</summary>
        [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object FetchSubmodules
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSecondarySourcesGitSubmodulesConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectSecondarySourcesGitSubmodulesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildProjectSecondarySourcesGitSubmodulesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#fetch_submodules CodebuildProject#fetch_submodules}.</summary>
            [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object FetchSubmodules
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
