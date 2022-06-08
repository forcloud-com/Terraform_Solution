using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildProjectEnvironmentRegistryCredentialOutputReference), fullyQualifiedName: "aws.codebuild.CodebuildProjectEnvironmentRegistryCredentialOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodebuildProjectEnvironmentRegistryCredentialOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodebuildProjectEnvironmentRegistryCredentialOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectEnvironmentRegistryCredentialOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectEnvironmentRegistryCredentialOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "credential", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Credential
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "credentialProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentRegistryCredential\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential? InternalValue
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential?>();
            set => SetInstanceProperty(value);
        }
    }
}
