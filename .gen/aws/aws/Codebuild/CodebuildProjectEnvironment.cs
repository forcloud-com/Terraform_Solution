using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectEnvironment")]
    public class CodebuildProjectEnvironment : aws.Codebuild.ICodebuildProjectEnvironment
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#compute_type CodebuildProject#compute_type}.</summary>
        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        public string ComputeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#image CodebuildProject#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public string Image
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#certificate CodebuildProject#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Certificate
        {
            get;
            set;
        }

        /// <summary>environment_variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#environment_variable CodebuildProject#environment_variable}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EnvironmentVariable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#image_pull_credentials_type CodebuildProject#image_pull_credentials_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imagePullCredentialsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImagePullCredentialsType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#privileged_mode CodebuildProject#privileged_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privilegedMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PrivilegedMode
        {
            get;
            set;
        }

        /// <summary>registry_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#registry_credential CodebuildProject#registry_credential}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registryCredential", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentRegistryCredential\"}", isOptional: true)]
        public aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential? RegistryCredential
        {
            get;
            set;
        }
    }
}
