using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildProjectEnvironmentOutputReference), fullyQualifiedName: "aws.codebuild.CodebuildProjectEnvironmentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodebuildProjectEnvironmentOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodebuildProjectEnvironmentOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectEnvironmentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectEnvironmentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRegistryCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentRegistryCredential\"}}]")]
        public virtual void PutRegistryCredential(aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentVariable")]
        public virtual void ResetEnvironmentVariable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImagePullCredentialsType")]
        public virtual void ResetImagePullCredentialsType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivilegedMode")]
        public virtual void ResetPrivilegedMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistryCredential")]
        public virtual void ResetRegistryCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "registryCredential", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentRegistryCredentialOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectEnvironmentRegistryCredentialOutputReference RegistryCredential
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectEnvironmentRegistryCredentialOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentVariableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvironmentVariableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imagePullCredentialsTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImagePullCredentialsTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privilegedModeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PrivilegedModeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryCredentialInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentRegistryCredential\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential? RegistryCredentialInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}]}}")]
        public virtual object EnvironmentVariable
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imagePullCredentialsType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImagePullCredentialsType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privilegedMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PrivilegedMode
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironment\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectEnvironment? InternalValue
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectEnvironment?>();
            set => SetInstanceProperty(value);
        }
    }
}
