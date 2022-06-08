using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildProjectSecondarySourcesGitSubmodulesConfigOutputReference), fullyQualifiedName: "aws.codebuild.CodebuildProjectSecondarySourcesGitSubmodulesConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodebuildProjectSecondarySourcesGitSubmodulesConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodebuildProjectSecondarySourcesGitSubmodulesConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectSecondarySourcesGitSubmodulesConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectSecondarySourcesGitSubmodulesConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "fetchSubmodulesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FetchSubmodulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object FetchSubmodules
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySourcesGitSubmodulesConfig\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectSecondarySourcesGitSubmodulesConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSecondarySourcesGitSubmodulesConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
