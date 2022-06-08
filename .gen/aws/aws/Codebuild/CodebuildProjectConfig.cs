using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    /// <summary>AWS CodeBuild.</summary>
    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectConfig")]
    public class CodebuildProjectConfig : aws.Codebuild.ICodebuildProjectConfig
    {
        /// <summary>artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#artifacts CodebuildProject#artifacts}
        /// </remarks>
        [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectArtifacts\"}")]
        public aws.Codebuild.ICodebuildProjectArtifacts Artifacts
        {
            get;
            set;
        }

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#environment CodebuildProject#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironment\"}")]
        public aws.Codebuild.ICodebuildProjectEnvironment Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#name CodebuildProject#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#service_role CodebuildProject#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceRole
        {
            get;
            set;
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source CodebuildProject#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSource\"}")]
        public aws.Codebuild.ICodebuildProjectSource Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#badge_enabled CodebuildProject#badge_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "badgeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? BadgeEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#build_timeout CodebuildProject#build_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BuildTimeout
        {
            get;
            set;
        }

        /// <summary>cache block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#cache CodebuildProject#cache}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectCache\"}", isOptional: true)]
        public aws.Codebuild.ICodebuildProjectCache? Cache
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#description CodebuildProject#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#encryption_key CodebuildProject#encryption_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionKey
        {
            get;
            set;
        }

        /// <summary>logs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#logs_config CodebuildProject#logs_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logsConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfig\"}", isOptional: true)]
        public aws.Codebuild.ICodebuildProjectLogsConfig? LogsConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#queued_timeout CodebuildProject#queued_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QueuedTimeout
        {
            get;
            set;
        }

        /// <summary>secondary_artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#secondary_artifacts CodebuildProject#secondary_artifacts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecondaryArtifacts
        {
            get;
            set;
        }

        /// <summary>secondary_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#secondary_sources CodebuildProject#secondary_sources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondarySources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecondarySources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_version CodebuildProject#source_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#tags CodebuildProject#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#vpc_config CodebuildProject#vpc_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectVpcConfig\"}", isOptional: true)]
        public aws.Codebuild.ICodebuildProjectVpcConfig? VpcConfig
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
