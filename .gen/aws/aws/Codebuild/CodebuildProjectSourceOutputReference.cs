using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildProjectSourceOutputReference), fullyQualifiedName: "aws.codebuild.CodebuildProjectSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodebuildProjectSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodebuildProjectSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectSourceAuth\"}}]")]
        public virtual void PutAuth(aws.Codebuild.ICodebuildProjectSourceAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectSourceAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitSubmodulesConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectSourceGitSubmodulesConfig\"}}]")]
        public virtual void PutGitSubmodulesConfig(aws.Codebuild.ICodebuildProjectSourceGitSubmodulesConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectSourceGitSubmodulesConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuth")]
        public virtual void ResetAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildspec")]
        public virtual void ResetBuildspec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitCloneDepth")]
        public virtual void ResetGitCloneDepth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitSubmodulesConfig")]
        public virtual void ResetGitSubmodulesConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInsecureSsl")]
        public virtual void ResetInsecureSsl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocation")]
        public virtual void ResetLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportBuildStatus")]
        public virtual void ResetReportBuildStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSourceAuthOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectSourceAuthOutputReference Auth
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectSourceAuthOutputReference>()!;
        }

        [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSourceGitSubmodulesConfigOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectSourceGitSubmodulesConfigOutputReference GitSubmodulesConfig
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectSourceGitSubmodulesConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSourceAuth\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectSourceAuth? AuthInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSourceAuth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildspecInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildspecInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitCloneDepthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GitCloneDepthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitSubmodulesConfigInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSourceGitSubmodulesConfig\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectSourceGitSubmodulesConfig? GitSubmodulesConfigInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSourceGitSubmodulesConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "insecureSslInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InsecureSslInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportBuildStatusInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReportBuildStatusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "buildspec", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Buildspec
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gitCloneDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GitCloneDepth
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "insecureSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object InsecureSsl
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ReportBuildStatus
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSource\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectSource? InternalValue
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
